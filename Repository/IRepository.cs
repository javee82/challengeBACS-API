using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository<T, TKey>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(TKey id);
        Task AddAsync(T item);
        void UpdateAsync(T item);
        Task DeleteAsync(TKey id);
    }
}
