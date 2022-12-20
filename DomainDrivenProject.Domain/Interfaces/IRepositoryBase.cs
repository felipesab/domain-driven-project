using System.Collections.Generic;

namespace DomainDrivenProject.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Dispose();
    }
}
