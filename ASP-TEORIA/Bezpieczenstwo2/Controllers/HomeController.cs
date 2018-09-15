using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Bezpieczenstwo2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Uzytkownicy()
        {
            return View("Uzytkownicy", Membership.GetAllUsers());
        }


        public ActionResult ZmienPrzynaleznoscDoGrupy(FormCollection formCollection)
        {
            string uzytkownik = formCollection["nazwaUzytkownika"];
            string grupa = formCollection["nazwaGrupy"];

            MembershipUser user = Membership.GetUser(uzytkownik);

            if(Roles.IsUserInRole(uzytkownik,grupa))
            {
                Roles.RemoveUserFromRole(uzytkownik, grupa);
            }
            else
            {
                Roles.AddUserToRole(uzytkownik, grupa);
            }
            return PartialView("GrupaUzytkownika", user);
        }

        public ActionResult UsunUzytkownika(string nazwaUzytkonwika)
        {
            Membership.DeleteUser(nazwaUzytkonwika);

            return Uzytkownicy();
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
    }
}