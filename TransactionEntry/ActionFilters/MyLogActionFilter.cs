using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TransactionEntry.ActionFilters
{
    public class MyLogActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log("On Action Executing", filterContext.RouteData);
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log("On Action Executed", filterContext.RouteData);
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Log("On Result Executing", filterContext.RouteData);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Log("On Result Executed", filterContext.RouteData);
        }
        private void Log(string logMessage, RouteData routeData)
        {
            var controllerName = routeData.Values["controller"];
            var actionName     = routeData.Values["action"];
            var message        = string.Format("{0}\nController : {1}\nAction Name : {2}"
                , logMessage, controllerName, actionName);

            Debug.WriteLine(message, "Action Filter Log");
        }
    }
}