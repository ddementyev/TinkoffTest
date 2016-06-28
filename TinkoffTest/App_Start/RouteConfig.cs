using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TinkoffTest
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Encode",
               url: "",
               defaults: new { controller = "Code", action = "Encode", shortUrl = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Decode",
               url: "{shortUrl}",
               defaults: new { controller = "Code", action = "Decode", shortUrl = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Code", action = "Encode", id = UrlParameter.Optional }
            );



        }
    }
}
