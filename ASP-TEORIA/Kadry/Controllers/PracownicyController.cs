using Kadry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kadry.Controllers
{
    public class PracownicyController : Controller
    {
        static List<PracownicyModels> listaPracownikow = new List<PracownicyModels>();

        // GET: Pracownicy
        public ActionResult UtworzPracownika()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult UtworzPracownika(PracownicyModels pracownik)
        {
            if(ModelState.IsValid)
            {
                listaPracownikow.Add(pracownik);
                return View("ListaPracownikow", listaPracownikow);
            }
            return View(pracownik);
        }

        public ActionResult ListaPracownikow()
        {
            return View(listaPracownikow);
        }
    }
}