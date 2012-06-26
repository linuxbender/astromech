﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Presentation.Web
{  
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {            
            filters.Add(new RequireHttpsAttribute());
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // short url for static pages
            routes.MapRoute("Home", "", new { controller = "Home", action = "Index" });
            routes.MapRoute("About","About",new { controller = "Home", action = "About" });
            routes.MapRoute("Help", "Help", new { controller = "Home", action = "Help" });
            routes.MapRoute("Contact", "Contact", new { controller = "Home", action = "Contact" });
            routes.MapRoute("Github", "Github", new { controller = "Home", action = "Github" });
            routes.MapRoute("SignIn", "SignIn", new { Area = "Account", Controller ="Login", Action ="SignIn"});
            
            // default mapping
            routes.MapRoute("Default", "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}