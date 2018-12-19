/*
HTTP verbs like Get, Post, Put and Delete.

Web Api restful project map these verbs to specific action
Web API decides which Web API controller and action method to execute 
e.g. 
    Get() method will handle HTTP GET request, 
    Post() method will handle HTTP POST request, 
    Put() mehtod will handle HTTP PUT request and 
    Delete() method will handle HTTP DELETE request for the above Web API.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWebApi.Controller
{
    public class ValuesController : ApiController
    {
        // GET: api/Values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Values
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Values/5
        public void Delete(int id)
        {
        }
        /*
        If you want to write methods that do not start with an HTTP verb 
        then you can apply the appropriate http verb attribute on the method 
        such as HttpGet, HttpPost, HttpPut etc. same as MVC controller. 
        */

        //[HttpGet]
        //public IEnumerable<string> Values()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //[HttpGet]
        //public string Value(int id)
        //{
        //    return "value";
        //}

        [HttpPost]
        public void SaveNewValue([FromBody]string value)
        {
        }

        [HttpPut]
        public void UpdateValue(int id, [FromBody]string value)
        {
        }

        [HttpDelete]
        public void RemoveValue(int id)
        {
        }
    }
}
