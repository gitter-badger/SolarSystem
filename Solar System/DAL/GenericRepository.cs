using System;
using System.Collections.Generic;
using System.Data.Entity;
using Model;

namespace DAL
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository()
        {
            this._context = new SolarSystemContext();
            this._dbSet = _context.Set<T>();
        }

        public GenericRepository(DbContext context)
        {
            this._context = context;
            this._dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }

        public T GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public T GetByName(String name)
        {
            return _dbSet.Find(name);
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(Guid id)
        {
            T entityToDelete = _dbSet.Find(id);
            Delete(entityToDelete);
        }

        public void Delete(T entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }
            _dbSet.Remove(entityToDelete);
        }

        public void Update(T entityToUpdate)
        {
            _dbSet.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void LazyLoadingEnabled(bool isEnable)
        {
            _context.Configuration.LazyLoadingEnabled = isEnable;
        }
    }
}
