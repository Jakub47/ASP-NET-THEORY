using Kontrolery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kontrolery.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Parametry(int par1, int par2, string par3)
        {
            var test = (string.Format("part1 {0}. par2 {1}, par3 {2}", par1, par2, par3));
            return View();
        }

        public void Parametry2(Ksiazka k)
        {
            Response.Write(string.Format("part1 {0}. par2 {1}, par3 {2}", k.Tytul, k.Autor, k.Cena));

        }

        //Jezeli checmy aby aplikacja nie była dostępna z poziomu przeglądarki!
        private ActionResult Index2()
        {
            return View();
        }
    }
}