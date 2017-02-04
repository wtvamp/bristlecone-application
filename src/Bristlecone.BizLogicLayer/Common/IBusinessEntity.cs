using System.Collections.Generic;

namespace Bristlecone.BusinessLayer.Common
{
    public interface IBusinessEntity<T>
    {
        void Create(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        void Update(T entity);
    }
}