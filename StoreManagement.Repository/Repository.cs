using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreManagement.DAL;

namespace StoreManagement.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private StoreManagementContext _dbContext;
        private DbSet<T> _dbSet;
        public Repository(StoreManagementContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }
        public Task Delete(T entity)
        {
            
        }

        public Task<T> Get(object input)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
