using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Model;
using Solar_System.DependencyResolver;

namespace Solar_System
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DependencyResolverConfig.Register();
            AreaRegistration.RegisterAllAreas();
            Database.SetInitializer(new SolarSystemInitializer());
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //InitializeDatabase();
        }

        private static void InitializeDatabase()
        {

            DbContext dbContext =
                (SolarSystemContext)System.Web.Mvc.DependencyResolver
                    .Current.GetService(typeof(DbContext));

            // Creates Database with custom configuration
            dbContext.Database.Initialize(true);

            // Seed new database with initial data
            //SeedDatabaseWithData();
        }

        //private static void SeedDatabaseWithData()
        //{
        //    DbContext dbContext =
        //            (SolarSystemContext)System.Web.Mvc.DependencyResolver
        //                .Current.GetService(typeof(DbContext));
        //
        //    var initializer=new SolarSystemInitializer();
        //    initializer.Seed((SolarSystemContext)dbContext);
        //}
    }
}