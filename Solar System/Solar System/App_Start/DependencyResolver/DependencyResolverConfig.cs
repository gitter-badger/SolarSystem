using System.Data.Entity;
using DAL;
using Model;
using Model.Models;
using Ninject;

namespace Solar_System.DependencyResolver
{
    public class DependencyResolverConfig
    {
        public static void Register()
        {
            IKernel kernel = new StandardKernel();

            kernel.Bind<DbContext>().To<SolarSystemContext>();
            kernel.Bind<IGenericRepository<SpaceObject>>().To<GenericRepository<SpaceObject>>();

            kernel.Bind<IDataManager>().To<DataManager>();

            System.Web.Mvc.DependencyResolver.SetResolver(new SolarSystemDependencyResolver(kernel));
        }
    }
}