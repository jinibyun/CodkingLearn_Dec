/*
Web API handles JSON and XML formats based on Accept and Content-Type headers. 
But, how does it handle these different formats? The answer is: By using Media-Type formatters. 

Media type formatters are classes responsible for serializing request/response data 
so that Web API can understand the request data format and send data in the format which client expects.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWebApi.Controller
{
    public class FormatterController : ApiController
    {
        // api/Formatter/
        public IEnumerable<string> Get()
        {
            IList<string> formatters = new List<string>();

            foreach (var item in GlobalConfiguration.Configuration.Formatters)
            {
                formatters.Add(item.ToString());
            }

            return formatters.AsEnumerable<string>();
        }
    }
}
