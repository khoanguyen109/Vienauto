using System.Web.Mvc;
using Castle.Windsor;
using Vienauto.Core.Dependency;

namespace VienautoMobile.App_Start
{
    public class DependencyConfig
    {
        private static readonly IWindsorContainer _container = new WindsorContainer();

        public static void Install()
        {
            _container.Install(new WebInstaller());
            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(_container, new WindsorActionInvoker(_container)));
        }
    }
}
