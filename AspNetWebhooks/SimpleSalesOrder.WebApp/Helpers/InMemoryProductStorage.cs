using SimpleSalesOrder.WebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace SimpleSalesOrder.WebApp.Helpers
{
    public class InMemoryProductStorage : IRepository<ProductViewModel>
    {
        private Dictionary<string, ProductViewModel> Storage = new Dictionary<string, ProductViewModel>();

        public void Add(ProductViewModel product)
        {
            this.Storage.Add(product.Id, product);
        }

        public IEnumerable<ProductViewModel> GetAll()
        {
            return Storage.Values.AsEnumerable();
        }

        public ProductViewModel Get(string Id)
        {
            ProductViewModel productInMemory;

            if (!this.Storage.TryGetValue(Id, out productInMemory))
            {
                return null;
            }

            return productInMemory;
        }
    }
}