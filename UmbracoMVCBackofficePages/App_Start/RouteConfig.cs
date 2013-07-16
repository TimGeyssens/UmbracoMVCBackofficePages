using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UmbracoMVCBackofficePages
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
               name: "ExampleMVCBackofficePages",
               url: "App_Plugins/UmbracoMVCBackofficePages/{action}/{id}",
               defaults: new { controller = "Example", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}