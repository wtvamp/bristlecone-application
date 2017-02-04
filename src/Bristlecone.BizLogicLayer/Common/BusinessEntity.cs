using System;
using System.Collections.Generic;
using Bristlecone.DataLayer.Common;
using Bristlecone.DataLayer.Interfaces;

namespace Bristlecone.BusinessLayer.Common
{
    public abstract class BusinessEntity<T> : IBusinessEntity<T> where T : BaseEntity
    {
        IGenericRepository<T> _repository;

        protected BusinessEntity(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _repository.Add(entity);
        }

        public void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            _repository.Delete(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            _repository.Edit(entity);
        }
    }
}