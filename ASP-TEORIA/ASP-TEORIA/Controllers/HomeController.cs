using ASP_TEORIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_TEORIA.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize(Roles = "Admin")]
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //[OutputCache]
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //[HandleError(ExceptionType = typeof(DivideByZeroException), View = "DzieleniePrzezZero")]
        public ActionResult Index()
        {
            var kursy = new List<Kursy>()
            {
                new Kursy(){Nazwa = "html", Opis = "Kurs html"},
                 new Kursy(){Nazwa = "css", Opis = "Kurs css"},
                  new Kursy(){Nazwa = "c++", Opis = "Kurs c++",},
                   new Kursy(){Nazwa = "c#", Opis = "Kurs C#"},
            };

            return View(kursy);
        }
    }
}