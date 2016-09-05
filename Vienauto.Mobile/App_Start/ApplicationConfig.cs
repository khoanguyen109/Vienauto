using System.Web.Hosting;
using Vienauto.Mobile.Configuration;
using Vienauto.Core.Nhibernate.Context;

namespace VienautoMobile.App_Start
{
    public class ApplicationConfig
    {
        public static void InitializeNhibernate()
        {
            //ISSession factory
            var configFile = HostingEnvironment.MapPath("~/" + AppSetting.NhibernateConfig);
            var mappingAssembly = typeof(Vienauto.Entity.Maps.ManufacturerMap).Assembly;
            NhibernateConfiguration.Init(configFile, mappingAssembly);
        }

        //public static void BindNHibernateSessionPerRequest(HttpApplication application)
        //{
        //    application.BeginRequest += application_BeginRequest;
        //    application.EndRequest += application_EndRequest;
        //    application.Error += application_Error;
        //}

        //private static void application_BeginRequest(object sender, EventArgs e)
        //{
        //    LazySessionContext.BindSessions();
        //}

        //private static void application_EndRequest(object sender, EventArgs e)
        //{
        //    LazySessionContext.UnbindSessions();
        //}

        //private static void application_Error(object sender, EventArgs e)
        //{
        //    LazySessionContext.UnbindSessions();
        //}
    }
}
