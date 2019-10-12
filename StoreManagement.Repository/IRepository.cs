﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreManagement.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(object input);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task SaveAsync();
    }
}
