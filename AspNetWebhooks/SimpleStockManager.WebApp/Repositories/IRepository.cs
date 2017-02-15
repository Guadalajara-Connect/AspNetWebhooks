using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleStockManager.WebApp.Models
{
    public interface IRepository<T>
    {
        Task AddAsync(T entity);

        Task<ICollection<T>> GetAllAsync();

        Task<T> GetAsync(string Id);
    }
}