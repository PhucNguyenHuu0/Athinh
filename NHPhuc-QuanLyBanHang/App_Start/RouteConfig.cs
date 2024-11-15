﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NHPhuc_QuanLyBanHang
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "NHPhuc_QuanLyBanHang.Controllers" });
            routes.MapRoute(
                 name: "Login",
                 url: "Login",
                  defaults: new { controller = "Login", action = "Index" });


            routes.MapRoute(
                name: "Dashboard",
                url: "Home/Dashboard",
                defaults: new { controller = "Home", action = "Dashboard" });

         
        }
    }
}
