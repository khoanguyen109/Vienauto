using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using VienautoMobile.App_Start;

namespace VienautoRemake
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //public override void Init()
        //{
            //base.Init();
            //ApplicationConfig.BindNHibernateSessionPerRequest(this);
            //ApplicationConfig.InitSessionFactory();
        //}

        protected void Application_Start()
        {
            DependencyConfig.Install();
            ApplicationConfig.InitializeNhibernate();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);            
        }
    }
}
