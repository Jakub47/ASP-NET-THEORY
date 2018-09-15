using Knockout_Szablony.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Knockout_Szablony.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var produkty = new[]
            {
                new Produkt {Nazwa = "Produkt1", DataDodania = "2010-01-01"},
                new Produkt {Nazwa = "Produkt2", DataDodania = "2011-05-10"},
                new Produkt {Nazwa = "Produkt3", DataDodania = "2009-02-03"}
            };
            return View(produkty);
        }
    }
}