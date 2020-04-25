using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje16WidgetBox.Models.Entity;

namespace Proje16WidgetBox.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        SchoolDbEntities1 db = new SchoolDbEntities1();
        public ActionResult Index()
        {
            var deger1 = db.TBLOGRENCİ.Count();
            var deger2 = db.TBLOGRENCİ.Where(x => x.SEHIR == "ankara").Count();
            ViewBag.dgr1 = deger1;
            ViewBag.dgr2 = deger2;
            return View();
        }
    }
}