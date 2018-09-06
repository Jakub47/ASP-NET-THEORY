using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MsAjax.Controllers
{
    public class ListaController : Controller
    {
        static List<string> listaElementow = new List<string>();

        // GET: Lista
        public ActionResult Index()
        {
            //ViewBag.Lista = new SelectList(listaElementow);
            return View();
        }

        public ActionResult DodajElementDoListy(FormCollection formCollection)
        {
            if(formCollection.Count > 0)
                listaElementow.Add(formCollection[0].ToString() + " " + 
                    DateTime.Now.ToLongTimeString());
            return View("Lista", listaElementow);
        }
    }
}