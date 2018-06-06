using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MikrokreditnaOrganizacijaNVM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Mikrokreditna organizacija NVM.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kontakt.";

            return View();
        }
        public ActionResult GetLocations()
        {
            var locations = new List<Models.Locations>()
            {
                 new Models.Locations(44.12796, 18.11516),
                  new Models.Locations(44.199034, 17.897899),
                   new Models.Locations(43.856604, 18.398149)
            };
            return Json(locations, JsonRequestBehavior.AllowGet);
        }
    }
}