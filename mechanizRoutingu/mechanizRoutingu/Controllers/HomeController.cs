using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mechanizRoutingu.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            var wynik = RouteTable.Routes.GetVirtualPath(null, new RouteValueDictionary(new { Controller = "mojKontroller", Action = "mojaAkcja", id = "454", parametr = "Marcin" }));
            string s = wynik.VirtualPath;
            return s;
        }
    }
}