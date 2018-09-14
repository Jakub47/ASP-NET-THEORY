using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bezpieczenstwo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [ValidateInput(false)]
        public string DodajKomentarz(FormCollection formCollection)
        {
            string komentarz =
                "<br /><b> " + Server.HtmlEncode(formCollection[0])
                + ":</b><br />" + Server.HtmlEncode(formCollection[1])
                + "<br />";
            return komentarz;
        }
    }
}