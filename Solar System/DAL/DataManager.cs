using System;
using System.Configuration;
using System.Data.Entity;
using Model.Models;

namespace DAL
{
    public partial class DataManager : IDataManager, IDisposable
    {
        private bool _isDisposed = false;
        private DbContext _context;
        private const String DbContextTypeKey = "dbContextTypeFullName";

        public DataManager()
        {
            Initialize();
        }

        private static Type GetType(String typeName)
        {
            var type = Type.GetType(typeName);
            if (type != null) return type;
            foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = a.GetType(typeName);
                if (type != null)
                {
                    return type;
                }
            }
            return null;
        }

        public void Initialize()
        {
            var dbContextTypeName = ConfigurationManager.AppSettings[DbContextTypeKey];
            if (String.IsNullOrEmpty(dbContextTypeName))
            {
                throw new InvalidOperationException();
            }

            var type = GetType(dbContextTypeName);

            if (type == null)
            {
                throw new InvalidOperationException();
            }

            _context = (DbContext)Activator.CreateInstance(type);
        }


        public void SetLazyLoadingEnabled(bool isLazyLoadingEnabled)
        {
            _context.Configuration.LazyLoadingEnabled = isLazyLoadingEnabled;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _isDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
