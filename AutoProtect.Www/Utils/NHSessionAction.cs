using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Routing;
using AutoProtect.Services;

namespace AutoProtect.Www.Utils
{
    public class NHSessionAction : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            NHSession.CurrentSession = NHibernateHelper.OpenSession();
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (NHSession.CurrentSession != null)
            {
                NHSession.CurrentSession.Dispose();
                NHSession.CurrentSession = null;
            }
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            
        }
    }
}


