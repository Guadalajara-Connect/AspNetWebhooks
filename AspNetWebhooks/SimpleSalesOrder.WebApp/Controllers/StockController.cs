using SimpleSalesOrder.WebApp.Models;
using System;
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

        public ActionResult AddToStock(ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                product.Id = Guid.NewGuid().ToString();
                productRepository.Add(product);
            }

            return View(product);
        }
    }
}