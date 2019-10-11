using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreManagement.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(object input);
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);
    }
}
