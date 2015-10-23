using System.Web.Http;

namespace CabBuddyAPI.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //config.EnableCors();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // GlobalConfiguration.Configuration.Routes.MapHttpRoute(
            //  name: "DefaultApi",
            //  routeTemplate: "api/{controller}/{id}",
            //  defaults: new { id = System.Web.Http.RouteParameter.Optional }
            //);
        }
    }
}
