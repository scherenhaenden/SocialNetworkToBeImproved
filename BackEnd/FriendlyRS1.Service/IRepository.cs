using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DataLayer.EntityModels;

namespace FriendlyRS1.Service
{
    public interface IRepository<TEntity> where TEntity :  class
    {
        TEntity Get(Expression<Func<TEntity, bool>> predicate, string[] entities);
        
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(string[] objects);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void Remove(TEntity entity);
    }
}
