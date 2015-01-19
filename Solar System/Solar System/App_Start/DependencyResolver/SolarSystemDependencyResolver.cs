using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using Ninject.Parameters;

namespace Solar_System.DependencyResolver
{
    public class SolarSystemDependencyResolver : IDependencyResolver
    {
        readonly IKernel _kernel;

        public SolarSystemDependencyResolver(IKernel kernel)
        {
            this._kernel = kernel;
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType, new IParameter[0]);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType, new IParameter[0]);
        }
    }
}