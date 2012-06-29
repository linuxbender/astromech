using System.Linq;
using Domain.Entity;

namespace Domain.Service
{
    interface ICrudAppService<TEntity> where TEntity : class, IEntity
    {
        void Create(TEntity entity);
        IQueryable<TEntity> Read();
        TEntity ReadById(int id);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
