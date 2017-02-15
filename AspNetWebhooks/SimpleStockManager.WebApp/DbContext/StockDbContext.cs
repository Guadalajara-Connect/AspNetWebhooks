using SimpleSalesOrder.WebApp.Models;
using System.Data.Entity;

namespace SimpleStockManager.WebApp
{
    public class StockDbContext : DbContext
    {
        public StockDbContext() : base("name=StockDbConnection")
        {
        }

        public DbSet<ProductViewModel> Products { get; set; }
    }
}