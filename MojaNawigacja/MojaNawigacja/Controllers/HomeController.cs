using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MojaNawigacja.Controllers
{
    public class HomeController : Controller
    {
        Int32? _idRekordu;
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Index(string id)
        //{
        //    if (!(id == null))
        //        _idRekordu = Convert.ToInt32(id);
        //    else
        //        HttpNotFound();

        //    ViewBag.IdRekordu = _idRekordu;
        //    return View();
        //}

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