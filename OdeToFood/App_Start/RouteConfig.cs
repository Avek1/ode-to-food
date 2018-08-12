using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OdeToFood
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // routes are ORDER-SENSITIVE

            // /Cuisine/french
            routes.MapRoute(
                name: "Cuisine",
                url: "cuisine/{name}",
                defaults: new { controller = "Cuisine", action = "Search", name = UrlParameter.Optional}  // for NAME param the current value is the same as an empty string.
                // i think this doesn't need the following key phrases to work: name; url; defaults.
                );

            // /Home
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
