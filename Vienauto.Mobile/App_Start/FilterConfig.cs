using System.Web.Mvc;
using VienautoMobile.Filters.Exception;

namespace VienautoRemake
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogErrorExceptionAttribute());
        }
    }
}
