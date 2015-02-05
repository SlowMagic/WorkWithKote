using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkWithKOTE.Models;
using System.Data;
namespace WorkWithKOTE.Controllers
{
    public class TourCreateController : Controller
    {
        //
        // GET: /TourCreate/
        TourContext db = new TourContext();
        public ActionResult TourCreate ()
        {
            ViewBag.DateTourId = new SelectList(db.DateTours, "DateTourId", "Date");
            ViewBag.DateTourId = new SelectList(db.DateTours, "DateTourId", "Date");
            return View();
        }
        [HttpPost]
        public ActionResult TourCreate(Tour model)
        {
            db.Entry(model).State = EntityState.Added;
            db.SaveChanges();
            return View();
        }
        public ActionResult DateCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult  DateCreate(DateTour model)
        {
            db.Entry(model).State = EntityState.Added;
            db.SaveChanges();
            return View();
        }
    }
}
