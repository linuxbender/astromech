using System;
using System.Linq;
using System.Linq.Expressions;

namespace Domain
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> AsQueryable();        

        IQueryable<T> Find(Expression<Func<T, bool>> predicate);

        IQueryable<T> EagerLoad<TProperty>(Expression<Func<T, TProperty>> path);

        T First(Expression<Func<T, bool>> predicate);

        T FindById(int id);

        void Update(T entity);

        void Insert(T entity);

        void Delete(T entity);
    }
}
