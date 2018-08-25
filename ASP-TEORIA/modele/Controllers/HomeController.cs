using modele.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modele.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Pracownik pracownik = new Pracownik()
            {
                PracownikId = 1,
                Imie = "Janusz",
                Nazwisko = "Torbacz",
                Miasto = "Gdańsk",
                Ulica = "Poznańska"
            };

            return View(pracownik);
        }
    }
}