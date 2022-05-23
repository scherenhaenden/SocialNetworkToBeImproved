using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataLayer.EntityModels;
using FriendlyRS1.Service;
using Microsoft.EntityFrameworkCore;

namespace FriendlyRS1.Repository.RepositorySetup
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<TEntity> _dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }
        public TEntity Get(Expression<Func<TEntity, bool>> predicate, string[] entities = null)
        {
            IQueryable<TEntity> query = _db.Set<TEntity>();
            if (entities != null)
            {
                foreach (string entity in entities)
                {
                    query = query.Include(entity);
                }
            }
            return query.Where(predicate).FirstOrDefault();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TType GetSingle<TType>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TType>> select) where TType : class
        {
            return _db.Set<TEntity>().Where(where).Select(select).SingleOrDefault();
        }

        public List<TType> GetList<TType>(Expression<Func<TEntity, TType>> select, Expression<Func<TEntity, bool>> where = null) where TType : class
        {
            if (where == null)
            {
                return _dbSet.Select(select).ToList();
            }

            
            return _db.Set<TEntity>().Where(where).Select(select).ToList();
        }

        public TEntity Find(int id)
        {
            return _dbSet.Find(id);
        }
        public IQueryable<TEntity> GetSelect(Expression<Func<TEntity, bool>> predicate, string[] entities)
        {
            IQueryable<TEntity> query = _db.Set<TEntity>();
            if (entities != null)
            {
                foreach (string entity in entities)
                {
                    query = query.Include(entity);
                }
            }
            return query.Where(predicate);
        }

        public IEnumerable<TEntity> GetAll(string[] entities = null)
        {
            /*IQueryable<TEntity> query = _db.Set<TEntity>();
            if (entities != null)
            {
                foreach (string entity in entities)
                {
                    query = query.Include(entity);
                }
            }*/
            return _dbSet.ToList();
        }

        public IEnumerable<TEntity> EagerLoading(string[] entities, Expression<Func<TEntity, bool>> predicate = null)
        {
            IQueryable<TEntity> query = _db.Set<TEntity>();
            foreach (string entity in entities)
            {
                query = query.Include(entity);
            }
            if (predicate == null)
                return query.ToList();
            else
                return query.Where(predicate).ToList();
        }
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _db.Set<TEntity>().Where(predicate);
        }
        public void Add(TEntity entity)
        {
            _db.Set<TEntity>().Add(entity);
        }
        public void Remove(TEntity entity)
        {
            _db.Set<TEntity>().Remove(entity);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            _dbSet.Attach(entityToUpdate);
            _db.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public int Count()
        {
            return _db.Set<TEntity>().Count();
        }
    }
}
