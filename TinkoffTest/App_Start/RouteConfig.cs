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
               defaults: new { controller = "Urls", action = "Encode", shortUrl = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Redirect",
               url: "{shortUrl}",
               defaults: new { controller = "Urls", action = "UrlRedirect", shortUrl = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Urls", action = "Encode", id = UrlParameter.Optional }
            );
        }
    }
}
