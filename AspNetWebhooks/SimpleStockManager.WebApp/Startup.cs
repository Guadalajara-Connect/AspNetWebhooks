using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleStockManager.WebApp.Startup))]
namespace SimpleStockManager.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
