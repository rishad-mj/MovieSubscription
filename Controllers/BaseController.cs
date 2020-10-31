using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieSubscription.Controllers
{
    public class BaseController :Controller
    {

        protected override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);

            //Log the exception
            filterContext.Result = new ViewResult() { ViewName = "Error" };
        }

    }
}