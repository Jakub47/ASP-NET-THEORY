using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mechanizRoutingu.Controllers
{
    [RoutePrefix("AtrybutPrefix")]
    public class SklepController : Controller
    {
        [Route("atrybut/routing/{parametr}/trasa")]
        public string Index(string parametr)
        {
            return "Definiowanie tras - Atrybuty";
        }

        public string Test(string parametr)
        {
            return parametr;
        }
    }
}