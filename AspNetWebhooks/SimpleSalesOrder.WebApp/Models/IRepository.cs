using System.Collections.Generic;

namespace SimpleSalesOrder.WebApp.Models
{
    public interface IRepository<T>
    {
        void Add(T entity);

        IEnumerable<T> GetAll();

        T Get(string Id);
    }
}