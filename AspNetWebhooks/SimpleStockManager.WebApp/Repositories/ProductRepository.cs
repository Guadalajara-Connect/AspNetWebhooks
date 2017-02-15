using SimpleSalesOrder.WebApp.Models;
using SimpleStockManager.WebApp.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleStockManager.WebApp.Repository
{
    public class ProductRepository : IRepository<ProductViewModel>
    {
        private readonly StockDbContext dbContext;

        public ProductRepository(StockDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddAsync(ProductViewModel product)
        {
            var savedProduct = this.dbContext.Products.Add(product);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<ICollection<ProductViewModel>> GetAllAsync()
        {
            return await this.dbContext.Products.ToListAsync();
        }

        public async Task<ProductViewModel> GetAsync(string Id)
        {
            return await this.dbContext.Products.Where(item => item.Id == Id).SingleOrDefaultAsync();
        }
    }
}