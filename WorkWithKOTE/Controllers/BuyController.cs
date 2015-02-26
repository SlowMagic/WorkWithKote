using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkWithKOTE.Models;
namespace WorkWithKOTE.Controllers
{

    public class BuyController : Controller
    {
        //
        // GET: /Buy/
        TourContext db = new TourContext();
        public ActionResult Index(int id )
        {
            Tour date = db.Tour.Find(id);
            ViewBag.TourPrices = date.Cost;
            Trip trip = new Trip();
            trip.TourPrice = date.Cost;
            ViewBag.DateTourId = new SelectList(db.DateTours.Where(m => m.TourId == id), "DateTourId", "FirstDate");
            return View(trip);
        }

    }
}
