using System;
using System.Linq;
using System.Linq.Expressions;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    /// <summary>
    /// IRepositoryBase pattern for encapsulating the logic of working with data sources.
    /// </summary>
    /// <typeparam name="T">parameter of model name.</typeparam>
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}