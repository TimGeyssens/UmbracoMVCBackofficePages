using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using System.Web.Routing;

namespace UmbracoMVCBackofficePages
{
    public class StartUpHandlers : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}