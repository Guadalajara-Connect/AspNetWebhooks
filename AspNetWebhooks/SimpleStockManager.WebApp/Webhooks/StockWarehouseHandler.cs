using Microsoft.AspNet.WebHooks;
using Newtonsoft.Json.Linq;
using SimpleSalesOrder.WebApp.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleStockManager.WebApp.Webhooks
{
    public class StockWarehouseHandler : WebHookHandler
    {
        public StockWarehouseHandler()
        {
            this.Receiver = CustomWebHookReceiver.ReceiverName;
        }

        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
            // Get data from Webhook.
            CustomNotifications data = context.GetDataOrDefault<CustomNotifications>();

            // Get the JObject from the Dictionary that corresponds to the "ProductViewModel" entrance.
            var productAsJObject = data.Notifications
                                    .First()
                                    .Where(item => item.Key == "ProductViewModel")
                                    .Select(item => item.Value)
                                    .FirstOrDefault();

            if (productAsJObject != null)
            {
                var newProduct = ((JObject)productAsJObject).ToObject<ProductViewModel>();
            }

            return Task.FromResult(true);
        }
    }
}