using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mechanizRoutingu
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                  name: "Samochód Szczegoły",
                  url: "samochod-{id}",
                  defaults: new { Controller = "Sklep", Action = "Szczegoly" }
                );

            routes.MapRoute(
                  name: "SamochodLista",
                  url: "model/{nazwa}",
                  defaults: new { Controller = "Sklep", Action = "Lista" },
                  constraints: new { nazwa = @"[\w]+"}
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
