using System.Web.Mvc;
using System.Web.Routing;
using CrossCutting.Common.Constant;

namespace Presentation.Web
{  
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {            
            //filters.Add(new RequireHttpsAttribute());
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // short url for static pages
            routes.MapRoute("Home", string.Empty, new { controller = ControllerConstant.HOME, action = "Index" });
            routes.MapRoute("About", "About", new { controller = ControllerConstant.HOME, action = "About" });
            routes.MapRoute("Help", "Help", new { controller = ControllerConstant.HOME, action = "Help" });
            routes.MapRoute("Contact", "Contact", new { controller = ControllerConstant.HOME, action = "Contact" });
            routes.MapRoute("Github", "Github", new { controller = ControllerConstant.HOME, action = "Github" });
            routes.MapRoute("SignIn", "SignIn", new { Area = AreaConstant.ACCOUNT, Controller = ControllerConstant.LOGIN , Action ="SignIn"});
            
            // default mapping
            routes.MapRoute("Default", "{controller}/{action}/{id}",
                new { controller = ControllerConstant.HOME, action = "Index", id = UrlParameter.Optional }
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