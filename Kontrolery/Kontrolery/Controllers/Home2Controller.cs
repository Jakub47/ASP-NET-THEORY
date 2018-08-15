using Kontrolery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kontrolery.Controllers
{
    public class Home2Controller : Controller
    {
        //[NonAction]
        //[ActionName("Edycja")]
        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Ksiazka k)
        {
            return View();
        }
    }
}