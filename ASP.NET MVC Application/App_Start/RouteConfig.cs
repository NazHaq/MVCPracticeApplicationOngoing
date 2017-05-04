using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP.NET_MVC_Application
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
          
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Additional routes for angular templates
            routes.MapRoute(
                name: "Registration_Courses",
                url: "Registration/Courses",
                defaults: new { controller = "Registration", action = "Index" }
            );

            routes.MapRoute(
                name: "Registration_Instructors",
                url: "Registration/Instructors",
                defaults: new { controller = "Registration", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
