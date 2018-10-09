using CTS_Models;
using CTS_Models.WagonDB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using CTS_Models.DBContext;
using System.Data.Entity.Migrations;

namespace CTS_BusinessProcesses
{
	public static class WagonDBSynchronizer
	{
		public static bool SyncOperation()
		{
			string stringForLoggerAccepted = "";
			string stringForLoggerRejected = "";
			string stringForLoggerWrong = "";
			//int lastID;
			List<WagonScale> wagonScales;
			List<Item> items;

			try
			{
				using (CtsDbContext centralDB = new CtsDbContext())
				{
					//var ltr = centralDB.WagonTransfers.Where(x => !x.ID.StartsWith("W")).OrderByDescending(t => t.TransferTimeStamp).Take(1000).Select(m => m.ID).ToArray();
					//lastID = (ltr.Length != 0) ? ltr.Select(x => int.Parse(x)).OrderByDescending(m => m).FirstOrDefault() : 0;
					wagonScales = centralDB.WagonScales.Include(m => m.Location).ToList();
					items = centralDB.Items.Include(m => m.Location).ToList();
				}

				var transfers = new List<ves_vagon>();
				using (var wagDB = new WagonDBcontext())
				{
					//transfers = wagDB.ves_vagon.Where(x => x.id > lastID).Include(m => m.scales).Include(h => h.napravlenie)
					//														.Include(n => n.otpravl).Include(k => k.poluch).ToList();

					transfers = wagDB.ves_vagon.Where(x => x.id_operator != null)
												.Where(x => x.id_operator != 0)
												.Where(x => x.sync != 1)
												.Include(m => m.scales)
												.Include(h => h.napravlenie)
												.Include(n => n.otpravl).Include(k => k.poluch).ToList();
				}

				if (transfers.Count > 0)
				{
					var acceptedTransfers = new List<WagonTransfer>();

					using (var centralDB = new CtsDbContext())
					{
						using (var transaction = centralDB.Database.BeginTransaction())
						{
							foreach (var t in transfers)
							{
								try
								{
									var scale = wagonScales.Where(x => x.LocationID == t.scales.name).FirstOrDefault();
									var item = items.Where(x => x.Name == t.gruz).FirstOrDefault();

									var transfer = new WagonTransfer()
									{
										ID = t.id.ToString(),
										TransferTimeStamp = t.date_time_brutto,
										LasEditDateTime = DateTime.Now,
										OperatorName = "DBSync",
										LotName = t.id_sostav.ToString() ?? "",
										SublotName = t.vagon_num ?? "",
										OrderNumber = t.nakladn ?? "",
										FromDestID = t.otpravl.name ?? "",
										ToDest = t.poluch.display_name ?? "",
										Tare = (float)t.ves_tara / 1000,
										Brutto = (float)t.ves_brutto / 1000,
										Netto = (float)t.ves_netto / 1000,
										NettoByOrder = (float)t.ves_netto_docs / 1000,
										EquipID = (scale != null) ? scale.ID : 1,
										ItemID = (item != null) ? item.ID : 1,
										Direction = t.napravlenie.display_name ?? "",
										IsValid = true,
										Status = 0,
									};

									var vc = new ValidationContext(transfer, null, null);
									var vResults = new List<ValidationResult>();
									var isValid = Validator.TryValidateObject(transfer, vc, vResults, true);
									if (isValid && (transfer.SublotName != ""))
									{
										acceptedTransfers.Add(transfer);
										centralDB.WagonTransfers.AddOrUpdate(transfer);
										stringForLoggerAccepted = String.Concat(stringForLoggerAccepted, t.id, ";");
									}
									else
									{
										stringForLoggerRejected = String.Concat(stringForLoggerRejected, t.id, ";");
									}
								}
								catch (ObjectDisposedException)
								{
									stringForLoggerWrong = String.Concat(stringForLoggerWrong, t.id, ";");
								}

							}

							centralDB.SaveChanges();
							transaction.Commit();
						}
					}

					using (var wagDB = new WagonDBcontext())
					{
						foreach (var t in acceptedTransfers)
						{
							var originalTransfer = wagDB.ves_vagon.Find(Int32.Parse(t.ID));
							originalTransfer.sync = 1;
							wagDB.Entry(originalTransfer).State = EntityState.Modified;
						}

						using (var transaction = wagDB.Database.BeginTransaction())
						{
							wagDB.SaveChanges();
							transaction.Commit();
						}
					}
				}

				Logger.MakeLog(string.Format("Successfully Synchronized WagonTranfers: {0}", stringForLoggerAccepted));
				Logger.MakeLog(string.Format("Successfully Synchronized WagonTranfers, not accepted transfers: {0}", stringForLoggerRejected));
				Logger.MakeLog(string.Format("Successfully Synchronized WagonTranfers, transfers with wrong properties: {0}", stringForLoggerWrong));

				return true;
			}
			catch (Exception ex)
			{
				Logger.MakeLog("Unsuccess with SyncWagonTranfers");
				Logger.MakeLog(ex.Message.ToString());

				return false;
			}
		}
	}
}
