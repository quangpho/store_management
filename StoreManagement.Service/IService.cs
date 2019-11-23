using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreManagement.Service
{
    public interface IService<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(object input);
        Task InsertAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(object input);
    }
}
