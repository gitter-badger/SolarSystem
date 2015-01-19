using Model.Models;

namespace DAL
{
    public partial class DataManager
    {
        #region IDataManager Members

        private GenericRepository<SpaceObject> _spaceObjects;

        public IGenericRepository<SpaceObject> SpaceObjects
        {
            get { return _spaceObjects ?? (_spaceObjects = new GenericRepository<SpaceObject>(_context)); }
        }

        #endregion
    }
}
