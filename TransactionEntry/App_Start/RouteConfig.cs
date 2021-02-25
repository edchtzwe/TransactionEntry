using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TransactionEntry
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            // /Entry/Search?query=<query string>
            routes.MapRoute(
                name: "Entry",
                url: "Search/{query}",
                defaults: new { controller = "Entry", action = "Search", query = UrlParameter.Optional }
            );
        }
    }
}
