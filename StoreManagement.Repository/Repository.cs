using Microsoft.EntityFrameworkCore;
using StoreManagement.DAL;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<T> GetAsync(object input)
        {
            return await _dbSet.FindAsync(input);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task InsertAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
