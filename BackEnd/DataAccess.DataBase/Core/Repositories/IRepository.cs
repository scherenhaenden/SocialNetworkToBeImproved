using System.Linq.Expressions;

namespace DataAccess.DataBase.Core.Repositories;

public interface IRepository<TEntity> where TEntity : class
{
    TEntity Get(int id);
    IEnumerable<TEntity> GetAll();
    IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        
    IQueryable<TEntity> GetAllQueryble();
    IQueryable<TEntity> FindQueryble(Expression<Func<TEntity, bool>> predicate);

    TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
    //TEntity LastUpdatedRow();

    void Add(TEntity entity);
    int AddWithIdentity(TEntity entity);
    void AddRange(IEnumerable<TEntity> entities);

    void Update(TEntity entity);

    void AddOrUpdate(Expression<Func<TEntity, bool>> predicate);

    void Remove(TEntity entity);
    void RemoveRange(IEnumerable<TEntity> entities);        
}