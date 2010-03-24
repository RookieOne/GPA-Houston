using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using GpaHouston.Framework;

namespace GpaHouston
{
    public class MvcApplication : HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            // needed to add this because of a Google Chrome issue
            // http://stackoverflow.com/questions/719678/custom-controller-factory-dependency-injection-structuremap-problems-with-asp
            routes.IgnoreRoute("{*favicon}", new {favicon = @"(.*/)?favicon.ico(/.*)?"});

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new {controller = "Home", action = "Index", id = ""} // Parameter defaults
                );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterRoutes(RouteTable.Routes);

            Bootstrapper.Config();
            ControllerBuilder.Current.SetControllerFactory(new StructureMapControllerFactory());
        }
    }
}