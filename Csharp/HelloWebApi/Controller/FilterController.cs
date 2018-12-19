/*
Web API includes filters to add extra logic before or after action method executes. 
Filters can be used to provide cross-cutting features 
such as logging, exception handling, performance measurement, authentication and authorization. 

Filters are actually attributes that can be applied on the Web API controller or one or more action methods. 

ref: http://www.tutorialsteacher.com/webapi/web-api-filters
*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace HelloWebApi.Controller
{
    [Log]
    public class FilterController : ApiController
    {
        // api/Filter/
        public string Get()
        {
            return "test";
        }
    }

    public class LogAttribute : ActionFilterAttribute
    {
        public LogAttribute()
        {

        }

        // print Output/Debug
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            Trace.WriteLine(string.Format("Action Method {0} executing at {1}", actionContext.ActionDescriptor.ActionName, DateTime.Now.ToShortDateString()), "Web API Logs");
        }

        // print Output/Debug
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            Trace.WriteLine(string.Format("Action Method {0} executed at {1}", actionExecutedContext.ActionContext.ActionDescriptor.ActionName, DateTime.Now.ToShortDateString()), "Web API Logs");
        }
    }
}
