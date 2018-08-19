using ASP_TEORIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_TEORIA.Controllers
{
    public class WidokiController : Controller
    {
        // GET: Widoki
        public ActionResult Index()
        {
            ViewData["DaneDoPrzekania"] = "Testowe dane do przekazania";
            ViewBag.Dane = "Test";

            var VM = new Adres() { Ulica = "Mila", Miasto = "Katowice" };

            return View(VM);
        }

        public ActionResult Zakupy()
        {
            return View();
        }

        public ActionResult Metoda()
        {
            return View();
        }
    }
}