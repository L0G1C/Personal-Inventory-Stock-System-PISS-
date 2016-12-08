using System.Web.Http;
using Piss.Entities.Repositories;
using Piss.Models.Repositories;


namespace Piss
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // SimpleInjector registrations

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
