using DomainDrivenProject.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace DomainDrivenProject.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public void Add(TEntity entity)
        {
            _serviceBase.Add(entity);
        }
        public void Update(TEntity entity)
        {
            _serviceBase.Update(entity);
        }

        public void Delete(TEntity entity)
        {
           _serviceBase.Delete(entity);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }


    }
}
