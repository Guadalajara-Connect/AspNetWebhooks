using SimpleSalesOrder.WebApp.Models;
using System.Web.Mvc;

namespace SimpleStockManager.WebApp.Controllers
{
    public class StockDetailsController : Controller
    {
        // GET: StockDetails
        public ActionResult Index(ProductViewModel product)
        {
            return View(product);
        }
    }
}