using System;
using System.Linq;
using Domain.Entity;

namespace Domain.Service
{    
    class CrudAppService<TEntity> : ICrudAppService<TEntity> where TEntity : class, IEntity
    {
        protected IRepository<TEntity> _repo;

        public CrudAppService(IRepository<TEntity> repo)
        {
            if (repo == null)
            {
                throw new Exception("IRepository");
            }
            _repo = repo;
        }

        public void Create(TEntity entity)
        {
            _repo.Insert(entity);
        }

        public IQueryable<TEntity> Read()
        {
            return _repo.AsQueryable();
        }

        public TEntity ReadById(int id)
        {
            return _repo.FindById(id);
        }

        public void Update(TEntity entity)
        {
            _repo.Update(entity);
        }

        public void Delete(int id)
        {
            _repo.Delete(_repo.FindById(id));
        }
    }
}
