using SimpleSalesOrder.WebApp.Models;
using SimpleStockManager.WebApp.Models;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SimpleSalesOrder.WebApp.Controllers
{
    public class StockController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(ProductViewModel newProduct)
        {
            if (ModelState.IsValid)
            {
                newProduct.Id = Guid.NewGuid().ToString();

                // Send a Webhook to all suscribed endpoints.
                await this.NotifyAllAsync("NewProductInStock", new { text = "Hola!" });

                return RedirectToAction("Index", "StockDetails", newProduct);
            }

            return View(newProduct);
        }
    }
}