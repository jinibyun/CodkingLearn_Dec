using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module1.Models;

namespace Module1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        static List<Customer> customers = new List<Customer>()
         {
         new Customer(){Id=1,Name = "Tom Cruise",Email = "tomcruise@gmail.com",Phone =
        "3322"},
         new Customer(){Id=1,Name = "Robert Downy Jr",Email = "robert@gmail.com",Phone
        = "326"},
         new Customer(){Id=1,Name = "Chris patt",Email = "cpatt@hotmail.com",Phone =
        "659"},
         };

        // GET: api/Customers
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return customers;
        }
        // GET: api/Customers/5
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }
        // POST: api/Customers
        [HttpPost]
        public IActionResult Post([FromBody]Customer customer)
        {
            if (ModelState.IsValid)
            {
                customers.Add(customer);
                return Ok();
            }
            return BadRequest(ModelState);
        }

        // PUT: api/Customers/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

    }
}