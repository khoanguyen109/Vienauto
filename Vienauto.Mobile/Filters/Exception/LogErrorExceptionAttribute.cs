using System.Web;
using Vendare.Error;
using System.Web.Mvc;
using System.Collections.Specialized;

namespace VienautoMobile.Filters.Exception
{
    public class LogErrorExceptionAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (filterContext.ExceptionHandled || !filterContext.HttpContext.IsCustomErrorEnabled
                || new HttpException(null, filterContext.Exception).GetHttpCode() != 500)
                return;

            filterContext.ExceptionHandled = true;
            filterContext.HttpContext.Response.Clear();
            filterContext.HttpContext.Response.StatusCode = 500;
            filterContext.HttpContext.Response.TrySkipIisCustomErrors = true;

            var exception = filterContext.Exception.InnerException;
            var actionName = filterContext.RouteData.Values["action"].ToString();
            var controllerName = filterContext.RouteData.Values["controller"].ToString();

            //Log error to files
            var detail = new NameValueCollection();
            detail.Add("Action", actionName);
            detail.Add("Controller", actionName);
            detail.Add("Exeption", filterContext?.Exception?.InnerException?.Message);
            new LoggableException(filterContext.Exception, detail);
        }
    }
}
