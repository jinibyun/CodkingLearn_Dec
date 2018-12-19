using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWebApi.Controller
{
    /*
    Web API Controller is similar to ASP.NET MVC controller. 
    It handles incoming HTTP requests and send response back to the caller. 
    
    Controller must inherit from  
    ApiController
    */


    public class HelloController : ApiController
    {
        // Get: api/Hello/
        public string Get()
        {
            return "Hello World";
        }
    }
}
