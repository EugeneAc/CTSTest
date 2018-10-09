using CTS_Analytics.Models.Mnemonic;
using System.Web;
using System.Linq;
using System.Web.Mvc;
using System;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Collections.Generic;
using CTS_Models;
using CTS_Models.DBContext;
using CTS_Models.DbViewModels;
using CTS_Analytics.Helpers;
using Newtonsoft.Json;

namespace CTS_Analytics.Controllers
{
    public partial class MnemonicController : Controller
    {
        private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();
        private string[] _locations = new string[] { "shah", "kuz", "kost", "abay", "len", "sar1", "sar3", "kaz", "tent" };

        public ActionResult Index(double fromdate = 0, double todate = 0)
        {
            //_logger.Trace("I'm here!");
            //_logger.Debug("Everything's ok!");

            //try
            //{
            //    throw new NullReferenceException("Smth went wrong :(");
            //}
            //catch (Exception ex)
            //{
            //    _logger.Error(ex, "Fix it!");
            //}

            var model = GetMnemoticMainModel(fromdate, todate);
            return View(model);
        }

        public ActionResult kotel()
        {
            var model = GetMnemoticMainModel();
            var shah = new Mine_Kotel("shah");
            shah.MineName = GetLocationNameOnCurrentLanguate("shah");
            ViewBag.shah = shah;
            var kuz = new Mine_Kotel("kuz");
            kuz.MineName = GetLocationNameOnCurrentLanguate("kuz");
            ViewBag.kuz = kuz;
            var kost = new Mine_Kotel("kost");
            kost.MineName = GetLocationNameOnCurrentLanguate("kost");
            ViewBag.kost = kost;
            var abay = new Mine_Kotel("abay");
            abay.MineName = GetLocationNameOnCurrentLanguate("abay");
            ViewBag.abay = abay;
            var len = new Mine_Kotel("len");
            len.MineName = GetLocationNameOnCurrentLanguate("len");
            ViewBag.len = len;
            var sar1 = new Mine_Kotel("sar1");
            sar1.MineName = GetLocationNameOnCurrentLanguate("sar1");
            ViewBag.sar1 = sar1;
            var sar3 = new Mine_Kotel("sar3");
            sar3.MineName = GetLocationNameOnCurrentLanguate("sar3");
            ViewBag.sar3 = sar3;
            var kaz = new Mine_Kotel("kaz");
            kaz.MineName = GetLocationNameOnCurrentLanguate("kaz");
            ViewBag.kaz = kaz;
            var tent = new Mine_Kotel("tent");
            tent.MineName = GetLocationNameOnCurrentLanguate("tent");
            ViewBag.tent = tent;

            return View(model);
        }

        public ActionResult Map()
        {
            var fromDate = GetDateFromCookie("fromdate");
            var toDate = GetDateFromCookie("todate");
            var serializedParent = JsonConvert.SerializeObject(GetMnemoticMainModel()); // https://stackoverflow.com/questions/988658/unable-to-cast-from-parent-class-to-child-class
            MnemonicMainMap model = JsonConvert.DeserializeObject<MnemonicMainMap>(serializedParent); // Because I am lazy
            model.AlarmDict = new Dictionary<string, AlarmCountModel>();
            Parallel.ForEach(_locations, (location) =>
            {
                var alarmsStatistics = AlarmHepler.GetMineAlarmCount(location, fromDate, toDate);
                var locationName = GetLocationNameOnCurrentLanguate(location);
                model.AlarmDict.Add(locationName, alarmsStatistics);
            });
            
            return View(model);
        }

        public ActionResult MapGps()
        {
            var model = GetMnemoticMainModel();
            return View(model);
        }

        private MnemonicMain GetMnemoticMainModel(double fromdate = 0, double todate = 0)
        {
            var model = new MnemonicMain();
            DateTime fromDate, toDate;
            GetDatesFromCookies(fromdate, todate, out fromDate, out toDate);


            try
            {
                var prodFactDataTask = Task.Run(() =>
                {
                    using (var cdb = new CtsDbContext())
                    {
                        var prodFactData = cdb.SkipTransfers.Where(d => d.TransferTimeStamp >= fromDate && d.TransferTimeStamp <= toDate).Where(v => v.IsValid == true).ToArray();
                        model.Kuz.ProdFact = GetProductionData("kuz", prodFactData);
                        model.Kost.ProdFact = GetProductionData("kost", prodFactData);
                        model.Abay.ProdFact = GetProductionData("abay", prodFactData);
                        model.Len.ProdFact = GetProductionData("len", prodFactData);
                        model.Sar1.ProdFact = GetProductionData("sar1", prodFactData);
                        model.Sar3.ProdFact = GetProductionData("sar3", prodFactData);
                        model.Kaz.ProdFact = GetProductionData("kaz", prodFactData);
                        model.Shah.ProdFact = GetProductionData("shah", prodFactData);
                        model.Tent.ProdFact = (decimal)GetBeltScaleModel(21, cdb, fromDate, toDate).ProductionPerTimeInterval;

                    }
                });
                var planDataTask = Task.Run(() =>
                {
                    using (var cdb = new CtsDbContext())
                    {
                        var planData = cdb.LocalPlansBWithLocationID.Where(d => d.Date >= fromDate && d.Date <= toDate).ToArray();
                        model.Kuz.ProdPlan = GetPlanData("kuz", planData);
                        model.Kost.ProdPlan = GetPlanData("kost", planData);
                        model.Abay.ProdPlan = GetPlanData("abay", planData);
                        model.Len.ProdPlan = GetPlanData("len", planData);
                        model.Sar1.ProdPlan = GetPlanData("sar", planData) / 2;
                        model.Sar3.ProdPlan = GetPlanData("sar", planData) / 2;
                        model.Kaz.ProdPlan = GetPlanData("kaz", planData);
                        model.Shah.ProdPlan = GetPlanData("shah", planData);
                        model.Tent.ProdPlan = GetPlanData("tent", planData);
                    }
                });
                var shippedDataTask = Task.Run(() =>
                {
                    using (var cdb = new CtsDbContext())
                    {
                        var shippedData = cdb.WagonTransfers.Where(d => d.TransferTimeStamp >= fromDate && d.TransferTimeStamp <= toDate).Where(v => v.IsValid == true).ToArray();
                        model.Kuz.Shipped = GetShippedData("kuz", shippedData);
                        model.Kost.Shipped = GetShippedData("kost", shippedData);
                        model.Abay.Shipped = GetShippedData("abay", shippedData);
                        model.Len.Shipped = GetShippedData("len", shippedData);
                        model.Sar1.Shipped = GetShippedData("sar1", shippedData);
                        model.Sar3.Shipped = GetShippedData("sar3", shippedData);
                        model.Kaz.Shipped = GetShippedData("kaz", shippedData);
                        model.Shah.Shipped = GetShippedData("shah", shippedData);
                        model.Tent.Shipped = GetShippedData("tent", shippedData);

                        model.StAbay.Outcome = GetShippedData("sabay", shippedData);
                        model.StDubov.Outcome = GetShippedData("sdub", shippedData);
                        model.StRaspor.Outcome = GetShippedData("srasp", shippedData);
                        model.StUgler.Outcome = GetShippedData("sugl", shippedData);

                        model.StAbay.Income = GetStationIncome(shippedData, cdb.Locations.Find("sabay").LocationName);
                        model.StDubov.Income = GetStationIncome(shippedData, cdb.Locations.Find("sdub").LocationName);
                        model.StRaspor.Income = GetStationIncome(shippedData, cdb.Locations.Find("srasp").LocationName);
                        model.StUgler.Income = GetStationIncome(shippedData, cdb.Locations.Find("sugl").LocationName);
                    }
                });
                var atStockpileTask = Task.Run(() =>
                {
                    using (var cdb = new CtsDbContext())
                    {
                        var skladData = cdb.WarehouseTransfers.Where(d => d.TransferTimeStamp >= fromDate && d.TransferTimeStamp <= toDate).ToArray();
                        model.Kuz.AtStockpile = GetStockpileValue("kuz", skladData);
                        model.Kost.AtStockpile = GetStockpileValue("kost", skladData);
                        model.Abay.AtStockpile = GetStockpileValue("abay", skladData);
                        model.Len.AtStockpile = GetStockpileValue("len", skladData);
                        model.Sar1.AtStockpile = GetStockpileValue("sar1", skladData);
                        model.Sar3.AtStockpile = GetStockpileValue("sar3", skladData);
                        model.Kaz.AtStockpile = GetStockpileValue("kaz", skladData);
                        model.Shah.AtStockpile = GetStockpileValue("shah", skladData);
                        model.Tent.AtStockpile = GetStockpileValue("tent", skladData);
                    }
                });
                Task.WaitAll(prodFactDataTask, planDataTask, shippedDataTask, atStockpileTask);
                model.Abay.MineName = GetLocationNameOnCurrentLanguate("abay");
                model.Kaz.MineName = GetLocationNameOnCurrentLanguate("kaz");
                model.Kost.MineName = GetLocationNameOnCurrentLanguate("kost");
                model.Kuz.MineName = GetLocationNameOnCurrentLanguate("kuz");
                model.Len.MineName = GetLocationNameOnCurrentLanguate("len");
                model.Sar1.MineName = GetLocationNameOnCurrentLanguate("sar1");
                model.Sar3.MineName = GetLocationNameOnCurrentLanguate("sar3");
                model.Shah.MineName = GetLocationNameOnCurrentLanguate("shah");
                model.Tent.MineName = GetLocationNameOnCurrentLanguate("tent");
                model.StAbay.StationName = GetLocationNameOnCurrentLanguate("sabay");
                model.StAbay.StationID = "sabay";
                model.StDubov.StationName = GetLocationNameOnCurrentLanguate("sdub");
                model.StAbay.StationID = "sbub";
                model.StRaspor.StationName = GetLocationNameOnCurrentLanguate("srasp");
                model.StAbay.StationID = "srasp";
                model.StUgler.StationName = GetLocationNameOnCurrentLanguate("sugl");
                model.StAbay.StationID = "sugl";
            }
            catch (Exception e)
            {
                _logger.Error(e, "Exception getting data for GetMnemoticMainModel");
            }

            return model;
        }

        private void GetDatesFromCookies(double fromdate, double todate, out DateTime fromDate, out DateTime toDate)
        {
            HttpCookie fromDateCoookie = Request.Cookies["fromdate"];
            HttpCookie toDateCoookie = Request.Cookies["todate"];
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
            if (fromdate != 0)
                fromDate = epoch.AddMilliseconds(fromdate);
            else
                fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            if (todate != 0)
                toDate = epoch.AddMilliseconds(todate);
            else
                toDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
        }

        private decimal GetPlanData(string location, IEnumerable<iLocalPlanWithLocationID> data)
        {
            var temp = data.Where(m => m.LocationID == location);
            var sum = temp?.Sum(st => st.Plan);
            return (decimal)sum;
        }

        private decimal GetProductionData(string location, IEnumerable<SkipTransfer> data)
        {
            var skipTransfers = data.Where(s => s.Equip.Location.ID == location && s.IsValid == true);
            // var sum = skipTransfers?.Sum(st => st.SkipWeight); // Leave old calculation for a while
            var sum = skipTransfers?.Select(st => int.Parse(st.LiftingID) * st.SkipWeight).Sum(); // TODO Change to this calculation when ready
            return (decimal)sum;
        }

		private float GetShippedData(string location, IEnumerable<WagonTransfer> data)
		{
			var temp = data.Where(t => t.Equip.LocationID.Equals(location));
			return (float)temp?.Sum(tr => tr.Netto);
		}

		private float GetStationIncome(IEnumerable<WagonTransfer> data, string locationName = "")
        {
            return data.Where(d => d.ToDest == locationName && d.IsValid == true)?.Sum(tr => tr.Netto) ?? 0;
        }

        private int GetStockpileValue(string locationName, IEnumerable<WarehouseTransfer> data)
        {
            var temp = data.Select(d => d.Warehouse.LocationID);
            var localData = data.Where(t => t.Warehouse.LocationID.Equals(locationName));
            if (localData.Count() > 0)
            return (int)localData
                .OrderBy(l => l.TransferTimeStamp)
                .Select(f => f.TotalQuantity)
                .LastOrDefault();

            return 0;
        }
    }
}