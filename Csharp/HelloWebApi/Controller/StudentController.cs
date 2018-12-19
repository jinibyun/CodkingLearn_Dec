using HelloWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWebApi.Controller
{
    public class StudentController : ApiController
    {
        // The Route attribute can be applied on any controller or action method.
        [Route("api/student/names")]
        public IEnumerable<string> Get()
        {
            return new string[] { "student1", "student2" };
        }

        // Parameter Binding
        // Get Action Method with Primitive Parameter
        // http://localhost:55830/api/Student/GetStudent?id=1
        [HttpGet]

        public Student GetStudent(int id)
        {
            return new Student { Id = 1, Name = "Jini Byun" };
        }

        // http://localhost:55830/api/Student/GetStudent?id=1&name=jini
        [HttpGet]
        public Student GetStudent(int id, string name)
        {
            return new Student { Name = "Jini Byun2" };
        }

        // Post Method with Primitive Parameter
        // http://localhost:55830/api/Student/AddStudent?Id=1&name=sdfdsf
        [HttpPost]
        [Route("api/Student/AddStudent")]
        public Student AddStudent(int id, string name)
        {
            var student = new Student();
            student.Name = name;
            student.Id = id;
            
            return student;
        }

        // Post Method with Complex Parameter
        // http://localhost:55830/api/Student/AddStudentComplex
        // NOTE: Web API will extract the JSON object from the Request body above and convert it into Student object automatically 
        // because names of JSON object properties matches with the name of Student class properties (case-insensitive).
        [HttpPost]
        [Route("api/Student/AddStudentComplex")]
        public Student AddStudentComplex(Student stu)
        {
            var student = new Student();
            student.Name = stu.Name;
            student.Id = stu.Id;

            return student;
        }

        // Post Method with Complex and Primitive Type (mixed)
        // NOTE: Post action method cannot include multiple complex type parameters because at most one parameter is allowed to be read from the request body.
        //  http://localhost:55830/api/Student/AddStudentMix?age=15   and json object are required
        [HttpPost]
        public Student AddStudentMix(int age, Student stu)
        {
            var student = new Student();
            student.Name = stu.Name;
            student.Id = stu.Id;
            student.Age = age;

            return student;
        }

        /*         
        Use [FromUri] attribute to force Web API to get the value of complex type from the query string 
        and [FromBody] attribute to get the value of primitive type from the request body, opposite to the default rule 
        */

        // http://localhost:55830/api/Student/GetStudents?Id=1&Name=steve&Age=33
        [HttpGet]
        public Student GetStudents([FromUri] Student stu)
        {
            // For example, if an HTTP GET request http://localhost:55830/api/Student/GetStudents?Id=1&Name=steve&Age=33 then 
            // Web API will create Student object and set its id and name property values to the value of id and name query string.
            var student = new Student();
            student.Name = stu.Name;
            student.Id = stu.Id;
            student.Age = stu.Age;
            return student;


        }

        /*
        NOTE:
        FromBody attribute can be applied on only one primitive parameter of an action method. 
        It cannot be applied on multiple primitive parameters of the same action method.
        */
        //[HttpPost]
        //// http://localhost:55830/api/Student/AddStudentFromBody
        //public Student AddStudentFromBody([FromBody]string name)
        //{
        //    var student = new Student();
        //    student.Name = name;            

        //    return student;
        //}
    }
}
