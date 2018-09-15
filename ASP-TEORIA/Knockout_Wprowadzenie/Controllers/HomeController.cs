using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Knockout_Wprowadzenie.Models;


namespace Knockout_Wprowadzenie.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var osoba = new Osoba { Imie = "Maciej", Nazwisko = "pakulski" };
            return View(osoba);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}