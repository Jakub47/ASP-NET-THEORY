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

        [HandleError(ExceptionType = typeof(DivideByZeroException), View = "DzieleniePrzezZero")]
        public ActionResult Index()
        {
            var zero = 0;
            int wynik = 2 / zero;
            return View();
        }
    }
}