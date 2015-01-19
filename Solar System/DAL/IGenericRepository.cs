using System;
using System.Collections.Generic;

namespace DAL
{
    public interface IGenericRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        T GetByName(String name);
        void Insert(T entity);
        void Delete(Guid id);
        void Delete(T entityToDelete);
        void Update(T entityToUpdate);
        void SaveChanges();
        void LazyLoadingEnabled(bool isEnable);
    }
}
