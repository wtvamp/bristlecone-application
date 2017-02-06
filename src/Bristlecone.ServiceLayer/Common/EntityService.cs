using Bristlecone.BusinessLayer.Common;
using Bristlecone.DataLayer.Common;
using BristleCone.ServiceLayer.Common;
using System;
using System.Collections.Generic;

namespace Bristlecone.Service.Common
{
    public abstract class EntityService<T> : IEntityService<T> where T : BaseEntity
    {
        private IBusinessEntity<T> _bizLayer;

        protected EntityService(IBusinessEntity<T> bizLayer)
        {
            _bizLayer = bizLayer;
        }

        public virtual void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _bizLayer.Create(entity);
        }


        public virtual void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            _bizLayer.Update(entity);
        }

        public virtual void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            _bizLayer.Delete(entity);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _bizLayer.GetAll();
        }
    }
}
