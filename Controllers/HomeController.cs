﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieSubscription.Controllers
{
    [AllowAnonymous]
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            //throw new Exception();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception();

            //return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}