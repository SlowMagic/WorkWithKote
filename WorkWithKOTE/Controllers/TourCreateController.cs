﻿using System;
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
            return View();
        }
        [HttpPost]
        public ActionResult TourCreate(Tour model, DateTour model1)
        {
            model.DiscriptionTour = Regex.Replace(model.DiscriptionTour, "<script.*?</script>", "", RegexOptions.IgnoreCase);
            model1.TourId = model.TourId;
            db.Entry(model1).State = EntityState.Added;
            db.Entry(model).State = EntityState.Added;
            db.SaveChanges();
            return View();
        }
    }
}
