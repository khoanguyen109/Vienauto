﻿using System.Web;
using System.Web.Mvc;
using VienautoMobile.Filters;

namespace VienautoRemake
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
