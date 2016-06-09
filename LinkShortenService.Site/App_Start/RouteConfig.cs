using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LinkShortenService.Site
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "GetLayout",
                url: "",
                defaults: new { controller = "Route", action = "GetLayout" }
                );

            routes.MapRoute(
                name: "GetView",
                url: "views/{section}/{view}",
                defaults: new { controller = "Route", action = "GetView" }
                );
        }
    }
}
