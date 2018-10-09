using CTS_Manual_Input.Attributes;
using CTS_Manual_Input.Helpers;
using CTS_Manual_Input.Models.Common;
using CTS_Manual_Input.Models.VehiModels;
using CTS_Models;
using CTS_Models.DBContext;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CTS_Manual_Input.Controllers
{

    [ErrorAttribute]
    public class VehiScalesController : Controller
    {
		CtsDbContext cdb = new CtsDbContext();

        public ActionResult Index(int page = 1)
        {
            var groups = UserHelper.GetUserDomainGroups(User.Identity.Name);
            List<string> locations = new List<string>();
            foreach (var group in groups)
            {
                locations.AddRange(cdb.Locations.Where(n => n.DomainName.Contains(group)).Select(l => l.DomainName));
            }
            ViewBag.Destinations = new SelectList(locations, "ID", "LocationName");
            int pagesize = 10;
            List<VehiTransfer> transfersperpage = new List<VehiTransfer>();
            List<VehiScale> scales = new List<VehiScale>();
            foreach (var location in locations)
            {
                transfersperpage.AddRange(cdb.VehiTransfers.Where(m => m.IsValid == true).Where(m => (m.FromDest.DomainName.Contains(location))).OrderByDescending(o => o.TransferTimeStamp).ToList().Where(d => d.LasEditDateTime >= DateTime.Now.AddHours(-48)));
                transfersperpage.AddRange(cdb.VehiTransfers.Where(m => m.IsValid == true).Where(m => (m.FromDest.DomainName.Contains(location))).OrderByDescending(o => o.TransferTimeStamp).ToList().Where(d => d.LasEditDateTime >= DateTime.Now.AddHours(-48)));
                //scales.AddRange(db.VehiScales.Where(l => l.Location.DomainName.Contains(location)).ToList());
            }

            VehiScales_Transfers model = new VehiScales_Transfers();
            transfersperpage.OrderByDescending(t => t.TransferTimeStamp);
            model.Transfers = transfersperpage.ToPagedList(page, pagesize);
            model.VehiScales = scales;
            return View(model);
        }

        [CanAddRoleAuthorization]
        [VehiUserAuthorization]
        public ActionResult Add(int? scaleID)
        {
            if (scaleID == null)
            {
                return HttpNotFound();
            }
            var locations = UserHelper.GetUserDomainGroups(User.Identity.Name);
            var destinations = new List<Location>();
            foreach (var location in locations)
            {
                destinations.AddRange(cdb.Locations.Where(l => l.DomainName.Contains("Авто")));
            }
            ViewBag.FromDestinations = new SelectList(destinations, "ID", "LocationName");
            var model = new VehiTransfer();
            model = new VehiTransfer();
            model.TransferTimeStamp = DateTime.Now;
            //model.Transfer.LotName = db.VehiScales.Find(scaleID).Location.ShortName + "_" + DateTime.Now.ToString("yyMMddHHmmss");
            model.EquipID = scaleID;
            model.ID = "V" + scaleID + (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            return View("Add", model);
        }
    }
}