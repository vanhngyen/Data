﻿using System.Web;
using System.Web.Mvc;

namespace Data_First_web_application
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
