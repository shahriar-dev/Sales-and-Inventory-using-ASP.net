﻿using System.Web;
using System.Web.Mvc;

namespace Sales_and_Inventory
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
