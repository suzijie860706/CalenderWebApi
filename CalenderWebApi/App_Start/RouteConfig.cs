using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CalenderWebApi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.MapRoute(
            //    name: "space",
            //    url: "",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
            //routes.MapRoute(
            //    name: "QQ",
            //    url: "CalenderApi/login/{id}",
            //    defaults: new { controller = "Login", action = "login", id = UrlParameter.Optional }
            //);
            //routes.MapRoute(
            //    name: "CalenderApi",
            //    url: "CalenderApi/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
            //routes.MapRoute(
            //    name: "TTT",
            //    url: "Login/login",
            //    defaults: new { controller = "Login", action = "login"}
            //);
            routes.MapRoute(
                name: "TQWE",
                url: "TT/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "CalenderApi",
                url: "CalenderApi/{action}/{id}",
                defaults: new { controller = "Login", action = "login", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "test",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "login", id = UrlParameter.Optional }
            );


        }
    }
}
