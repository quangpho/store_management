﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreManagement.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(object input);
        Task InsertAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task SaveAsync();
    }
}
