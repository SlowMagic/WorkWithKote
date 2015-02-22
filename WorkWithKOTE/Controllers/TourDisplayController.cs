using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkWithKOTE.Models;
namespace WorkWithKOTE.Controllers
{
    public class TourDisplayController : Controller
    {
        //
        // GET: /TourDisplay/
        TourContext db = new TourContext();
        public ActionResult Index(int id=0)
        {
            var data = db.Tour.Find(id);
            if(data.IsBus)
            { ViewBag.Message = "Автобус"; }
            if(data.IsAriplane)
            { ViewBag.Message1 = "Авиалинии"; }
            if (data.IsShip)
            { ViewBag.Message2 = "Лайнером"; }
            return View(data);
        }
        public ActionResult DatePartial(int id)
        {

            var date = db.DateTours.Where(m => m.TourId == id);

            return PartialView(date);
        }
        public ActionResult DopUsluga(int id)
        {

            var date = db.DopUslugs.Where(m => m.TourId == id);

            return PartialView(date);
        }
        public ActionResult Teg(int id)
        {

            var date = db.Teg.Where(m => m.TourId == id);

            return PartialView(date);
        }
    }
}
