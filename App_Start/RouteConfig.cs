﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MovieSubscription
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(name:"MoviesByReleaseDate",
            //                url:"Movies/released/{year}/{month}",
            //                new {Controller="Movies",action= "ByReleaseDate" },
            //                new { year=@"\d{4}",month=@"\d{2}"}); //route Constrains

            routes.MapMvcAttributeRoutes(); //Toenable Mvc attribute routes

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new string[] { "MovieSubscription.Controllers" }
            );
        }
    }
}
