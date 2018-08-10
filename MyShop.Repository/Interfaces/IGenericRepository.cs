﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MyShop.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : class 
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void Add(T entity, string createdBy = null);
        void AddRange(IEnumerable<T> entities);

        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        void SaveChanges();
    }
}