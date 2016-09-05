using Castle.Windsor;
using Vienauto.Core.Extension;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace Vienauto.Core.Dependency
{
    /// <summary>
    /// A action invoker will invoke the action with specified controller context. 
    /// Implementing ControllerActionInvoker allows to inject IOC properties into controller.
    /// </summary>
    public class WindsorActionInvoker : ControllerActionInvoker
    {
        private readonly IWindsorContainer _container;

        public WindsorActionInvoker(IWindsorContainer container)
        {
            _container = container;
        }

        protected override ActionExecutedContext InvokeActionMethodWithFilters(ControllerContext controllerContext, IList<IActionFilter> filters, ActionDescriptor actionDescriptor, IDictionary<string, object> parameters)
        {
            filters.ForEach(f => _container.InjectProperties(f));
            return base.InvokeActionMethodWithFilters(controllerContext, filters, actionDescriptor, parameters);
        }

        protected override AuthenticationContext InvokeAuthenticationFilters(ControllerContext controllerContext, IList<IAuthenticationFilter> filters, ActionDescriptor actionDescriptor)
        {
            filters.ForEach(f => _container.InjectProperties(f));
            return base.InvokeAuthenticationFilters(controllerContext, filters, actionDescriptor);
        }
    }

    public static class ObjectFactoryExtensions
    {
        public static void InjectProperties(this IWindsorContainer _container, object target)
        {
            var type = target.GetType();
            foreach (var property in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (property.CanWrite && _container.Kernel.HasComponent(property.PropertyType))
                {
                    var value = _container.Resolve(property.PropertyType);
                    try
                    {
                        property.SetValue(target, value, null);
                    }
                    catch (Exception ex)
                    {
                        var message = string.Format("Error setting property {0} on type {1}, See inner exception for more information.", property.Name, type.FullName);
                        throw new System.Exception(message, ex);
                    }
                }
            }
        }
    }
}
