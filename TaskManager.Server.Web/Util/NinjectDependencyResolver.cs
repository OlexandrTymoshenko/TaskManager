using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskManager.DAL.EF;
using TaskManager.DAL.Infrastrucrure;
using TaskManager.DAL.Interfaces;
using TaskManager.Management.Account;
using TaskManager.Management.Interfaces;
using TaskManager.Management.Workflow;

namespace TaskManager.Server.Web.Util
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument("context",new DataContext("DBConnection"));
            kernel.Bind<IUserManager>().To<UserManager>();
            kernel.Bind<IDomainTaskManager>().To<DomainTaskManager>();
        }
    }
}