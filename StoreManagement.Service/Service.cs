using StoreManagement.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreManagement.Service
{
    public class Service<T> : IService<T> where T : class
    {
        private IRepository<T> _repository;
        public Service(IRepository<T> repository)
        {
            this._repository = repository;
        }
        public async Task DeleteAsync(object input)
        {
            var entity = await _repository.GetAsync(input);
            _repository.Delete(entity);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<T> GetAsync(object input)
        {
            return await _repository.GetAsync(input);
        }

        public async Task InsertAsync(T entity)
        {
            _repository.Insert(entity);
            await _repository.SaveAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _repository.Update(entity);
            await _repository.SaveAsync();
        }
    }
}
