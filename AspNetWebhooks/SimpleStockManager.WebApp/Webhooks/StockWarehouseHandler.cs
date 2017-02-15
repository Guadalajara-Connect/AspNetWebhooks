using Microsoft.AspNet.WebHooks;
using System.Threading.Tasks;

namespace SimpleStockManager.WebApp.Webhooks
{
    public class StockWarehouseHandler : WebHookHandler
    {
        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
            return Task.FromResult(true);
        }
    }
}