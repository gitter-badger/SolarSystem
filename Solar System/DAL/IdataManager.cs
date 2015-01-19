using Model.Models;

namespace DAL
{
    public interface IDataManager
    {
        IGenericRepository<SpaceObject> SpaceObjects { get; }

        void SetLazyLoadingEnabled(bool isLazyLoadingEnabled);
        void Save();
    }
}
