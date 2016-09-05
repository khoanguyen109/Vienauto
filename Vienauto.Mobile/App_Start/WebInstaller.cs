using System.Web.Mvc;
using Castle.Windsor;
using Vienauto.Core.Dependency;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;

namespace VienautoMobile.App_Start
{
    public class WebInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly().BasedOn<IController>().If(t => t.Name.EndsWith("Controller"))
                .LifestyleScoped<WindsorHybridScopeAccessor>());

            //container.Register(Classes.FromAssemblyContaining<IReportService>().Where(x => typeof(IServiceBase).IsAssignableFrom(x))
            //    .WithServiceDefaultInterfaces().LifestyleScoped<WindsorHybridScopeAccessor>());
            //container.Register(Classes.FromAssemblyContaining<IAnimalRepository>().Where(x => typeof(IRepository).IsAssignableFrom(x))
            //    .WithServiceDefaultInterfaces().LifestyleScoped<WindsorHybridScopeAccessor>());
            //container.Register(Classes.FromAssemblyContaining<ILookupQueryBuilder>().Where(x => typeof(IQueryBuilder).IsAssignableFrom(x))
            //    .WithServiceDefaultInterfaces().LifestyleScoped<WindsorHybridScopeAccessor>());

        }
    }
}
