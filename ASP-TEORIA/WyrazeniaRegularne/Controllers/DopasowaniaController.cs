using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace WyrazeniaRegularne.Controllers
{
    public class DopasowaniaController : Controller
    {
        static List<string> listaWyrazenDoSprawdzenia = new List<string>();
        static List<string> wyrazeniaPasujaceDoWzorca = new List<string>();
        // GET: Dopasowania
        public ActionResult Index(string wzorzec)
        {
            ViewData["listaWyrazenDoSprawdzenia"] = new MultiSelectList(
                listaWyrazenDoSprawdzenia, wyrazeniaPasujaceDoWzorca);
            ViewData["Wzorzec"] = wzorzec;
            return View();
        }

        [HttpPost]
        public ActionResult DodajElementDoSprawdzenia(FormCollection form)
        {
            if(form != null)                
                listaWyrazenDoSprawdzenia.Add(form["ElementDoSprawdzenia"].ToString());

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult WyczyscListe()
        {
            listaWyrazenDoSprawdzenia.Clear();
            wyrazeniaPasujaceDoWzorca.Clear();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult SprawdzDopasowania(FormCollection form)
        {
            string wzorzec = form["Wzorzec"].ToString();


            if(listaWyrazenDoSprawdzenia.Count > 0 && !String.IsNullOrEmpty(wzorzec))
            {
                wyrazeniaPasujaceDoWzorca.Clear();
                foreach (var item in listaWyrazenDoSprawdzenia)
                {
                    if (!Regex.IsMatch(item, wzorzec))
                        wyrazeniaPasujaceDoWzorca.Add(item);
                }
            }

            return RedirectToAction("Index", new { wzorzec });
        }
    }
}