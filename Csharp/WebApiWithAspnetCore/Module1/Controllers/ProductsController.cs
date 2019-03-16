using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Module1.Controllers
{
    // [Produces("application/json")]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        static List<Product> _products = new List<Product>()
            {
                new Product() { ProductId = 1, ProductName = "Laptop", ProductPrice = 99.23M },
                new Product() { ProductId = 2, ProductName = "Desktop", ProductPrice = 55.34M }
            };

        // GET: api/<controller>
        //[HttpGet]
        //public IEnumerable<Product> Get()
        //{
        //    return _products;

        //}


        // same as Get method 
        // As long as method prefix is "Get" which is same as Http Verb "Get"
        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok(_products);
            // return StatusCode(StatusCodes.Status201Created);
        }

        // Custom method
        // NOTE: unless giving name, "Get" has two, which went wrong
        // /api/products/LoadWelcomeMessage
        [HttpGet("LoadWelcomeMessage")]
        public IActionResult GetWelcomeMessage()
        {
            return Ok("Welcome to our store...");
        }

        // GET api/<controller>/5        
        [HttpGet("{id}")]
        public string GetProduct(int id) 
        {
            return "value";
        }

        
        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            _products.Add(product);
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Product product)
        {
            _products[id] = product;
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _products.RemoveAt(id);
        }
    }
}
