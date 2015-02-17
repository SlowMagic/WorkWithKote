using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkWithKOTE.Models;
using System.Data;
using System.Text.RegularExpressions;
using System.IO;
namespace WorkWithKOTE.Controllers
{
    public class TourCreateController : Controller
    {
        //
        // GET: /TourCreate/
        TourContext db = new TourContext();
        public ActionResult TourCreate()
        {
            ViewBag.GalleryID = new SelectList(db.Gallery, "GalleryId", "GalleryName");
         /*   Tour tour = new Tour();
            tour.DateTour = new List<DateTour>{
                 new DateTour{FirstDate = "Введите дату",SecondDate="Введите дату"}
             };
            */
             return View();
        }
        [HttpPost]
        public ActionResult TourCreate(Tour model,HttpPostedFileBase TourImg,HttpPostedFileBase Document)
        {
           // model.DiscriptionTour = Regex.Replace(model.DiscriptionTour, "<script.*?</script>", "", RegexOptions.IgnoreCase);
            db.Entry(model).State = EntityState.Added;
            db.SaveChanges();
            return View();
        }
        public ViewResult EmptyDateTour()
        {
            return View("PartialDateTour", new DateTour());
        }
    }
}
