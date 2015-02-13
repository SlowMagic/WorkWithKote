using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace WorkWithKOTE.Models
{
    public class TourContext:DbContext
    {
        public TourContext ()
            :base("DefaultConnection")
    {

    }

        public DbSet<Tour> Tours { get; set; }

        public DbSet<DateTour> DateTours { get; set; }

        public DbSet<DopUslug> DopUslugs { get; set; }
        public DbSet<Gallery> Gallery { get; set; }
        public DbSet<RoutePoint> RoutePoint { get; set; }
    }
    [Table ("Tour")]
   public class Tour
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
       public int TourId { get; set; }
       public string NameTour {get;set;}
       public string TitleTour { get; set; }
       [AllowHtml]
        [Required]
       public string DiscriptionTour { get; set; }
       public float? Cost { get; set; }
       public string Valuta { get; set; }
       public string PrePay { get; set; }
       public string Reservation { get; set; }
       public bool Bus { get; set; }
       public bool Ariplane { get; set; }
       public bool Ship { get; set; }
       public string PodpicePrice { get; set; }
       public string AukcionPrice { get; set; }
       public string KommisiaAgent { get; set; } 
       public string SuppName { get; set; }
       public string SuppVkontakte { get; set; }
       public string SuppFoto { get; set; }
       public string SuppDiscription { get; set; }
       public string KindOfPay { get; set; }
       public int? People { get; set; }
       public int? AllPeople { get; set; }
       public string TourImg { get; set; }
       public string PohozTour { get; set; }
       public string Document { get; set; }
       public float? Bonus { get; set; }
       public string Teg { get; set; }
       public List<RoutePoint> RoutePoints { get; set; }
       public ICollection<DateTour> DateTour { get; set; }
       public List<DopUslug> DopUsluga { get; set; }
       public int? GalleryID { get; set; }

    }
    public class RoutePoint
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int RoutePointID { get; set; }
        public int TourId { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public int Order { get; set; }
    }
    [Table ("DateTour")]
    public class DateTour
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int DateTourId { get; set; }
        public int TourId { get; set; }
        public Tour Tour { get; set; }
        [DataType(DataType.Date)]
        public string FitstDate { get; set; }
        public string SeconDate { get; set; }
    }
    [Table ("Gallery")]
    public class Gallery
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int GalleryId { get; set; }
        public string GalleryName { get; set; }
        public string FirstImg { get; set; }
        public string SecondImg { get; set; }
        public string ThirdImg { get; set; }
    }
    [Table ("DopUslug")]
    public class DopUslug
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int DopUslugId { get; set; }
        public string DopUsluga { get; set; }
        public float? Price { get; set; }
        public int TourId { get; set; }
    }
}