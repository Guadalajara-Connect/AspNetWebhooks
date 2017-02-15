using System.Web.Http;

namespace SimpleStockManager.WebApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Load Web API controllers and Azure Storage Store for Webhooks producer.
            config.InitializeCustomWebHooks();
            config.InitializeCustomWebHooksAzureStorage();
            config.InitializeCustomWebHooksApis();
        }
    }
}