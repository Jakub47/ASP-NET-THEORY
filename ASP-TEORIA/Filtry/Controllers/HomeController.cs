using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtry.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

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


        [HandleError(View = "Blad", ExceptionType = typeof(ArgumentException))]
        public ActionResult PobierzParametr(int parammetr)
        {
            if (parammetr <= 0)
                throw new ArgumentException("Parametr tej metody nie moze byc ujemny");
            else if (parammetr == 0)
                throw new ApplicationException();

            else
                return View("Index");
        }

        [HandleError]
        public ActionResult PustaMetoda()
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public string WyswietlTajneDane()
        {
            return "To sa dane ktore nie powinny tradic w niepolowane rece";
        }
    }
}