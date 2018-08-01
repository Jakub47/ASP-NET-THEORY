using pierwszaAplikacja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pierwszaAplikacja.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var kontakt = new List<Kontakt>
            {
                new Kontakt {Imie = "Adam" , Nazwisko = "Nowak" , Miasto = "Katowice" , Ulica = "Adama" },
                new Kontakt {Imie = "Tomek" , Nazwisko = "Kowal" , Miasto = "Warszawa" , Ulica = "Kolista" },
                new Kontakt {Imie = "Jacek" , Nazwisko = "Cun" , Miasto = "Kraków" , Ulica = "Miła" }
            };
            ViewBag.Kontakty = kontakt;
            return View();
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