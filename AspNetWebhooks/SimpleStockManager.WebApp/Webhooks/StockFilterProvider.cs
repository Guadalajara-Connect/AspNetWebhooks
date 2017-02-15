using Microsoft.AspNet.WebHooks;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace SimpleStockManager.WebApp.Webhooks
{
    public class StockFilterProvider : IWebHookFilterProvider
    {
        private readonly Collection<WebHookFilter> filters = new Collection<WebHookFilter>
        {
            new WebHookFilter { Name = "NewProductInStock", Description = "A new brand product has been added to the stock."}
        };

        public Task<Collection<WebHookFilter>> GetFiltersAsync()
        {
            return Task.FromResult(this.filters);
        }
    }
}