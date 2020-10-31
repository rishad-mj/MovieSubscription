using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieSubscription.App_Start
{
    public class HandleGenericError : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);

            filterContext.Result = new ViewResult() { ViewName = "Error" };
        }
    }
}