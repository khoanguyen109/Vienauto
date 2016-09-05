using Castle.Windsor;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vienauto.Core.Dependency
{
    /// <summary>
    /// Implement a Windsor controller factory.
    /// </summary>
    public class WindsorControllerFactory : DefaultControllerFactory
    {
        private readonly IWindsorContainer _container;
        private readonly IActionInvoker _actionInvoker;

        public WindsorControllerFactory(IWindsorContainer container)
            : this(container, null)
        {
        }

        public WindsorControllerFactory(IWindsorContainer container, IActionInvoker actionInvoker)
        {
            _container = container;
            _actionInvoker = actionInvoker;
        }

        public override void ReleaseController(IController controller)
        {
            _container.Release(controller);
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            var controller = (Controller)_container.Resolve(controllerType);
            if (controller == null && _actionInvoker != null)
                controller.ActionInvoker = _actionInvoker;
            return controller;
        }
    }
}
