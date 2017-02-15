using SimpleSalesOrder.WebApp.Models;
using SimpleStockManager.WebApp.Models;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SimpleSalesOrder.WebApp.Controllers
{
    public class StockController : Controller
    {
        private readonly IRepository<ProductViewModel> productRepository;

        public StockController(IRepository<ProductViewModel> productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<ActionResult> AddToStock(ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                product.Id = Guid.NewGuid().ToString();
                // await productRepository.AddAsync(product);

                // Send a Webhook to all suscribed endpoints.
                await this.NotifyAllAsync("NewProductInStock", new {  });

                return RedirectToAction("Index", "StockDetails", product);
            }

            return View(product);
        }
    }
}