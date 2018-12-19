/*
The Web API action method can have following return types.

1. Void: see belew simple method
2. Primitive type or Complex type: refer to previous example: StudentController
3. HttpResponseMessage: 
    Web API controller always returns an object of HttpResponseMessage to the hosting infrastructure.
4. IHttpActionResult:
    The IHttpActionResult was introduced in Web API 2 (.NET 4.5). 
    An action method in Web API 2 can return an implementation of 
    IHttpActionResult class which is more or less similar to ActionResult class in ASP.NET MVC.
*/

using HelloWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWebApi.Controller
{
    public class CourseController : ApiController
    {
        // DELETE: api/Delete/5
        public void Delete(int id)
        {
            // 204 response means OK 
        }

        // GET with HttpRespnseMessage
        [Route("api/Course/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            Course course = new Course { Id = 1, Name = "CSharp" };
            var found = course.Id == id;
            if (!found)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, id);
            }

            return Request.CreateResponse(HttpStatusCode.OK, course);
        }

        [Route("api/Course/GetCourse/{id}")]
        [HttpGet]
        public IHttpActionResult GetCourse(int id)
        {
            Course course = new Course { Id = 2, Name = "Java" };
            var found = course.Id == id;
            if (!found)
            {
                return NotFound();
            }

            return Ok(course);

            // Ok() and NotFound()
        }
    }


}
