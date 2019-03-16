using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module1.Models;

namespace Module1.Controllers
{
    // apiVersion : check startup.cs
    // it requires package named "Microsoft.AspNetCore.Mvc.Versioning"
    // 1. querystring versioning: http://localhost:2473/api/movies?api-version=2.0
    // [ApiVersion("1.0")] 
    // [Route("api/movies")]

    // 2. url versioning: http://localhost:2473/api/v1/movies
    // [ApiVersion("1.0")]
    // [Route("api/v{version:apiVersion}/movies")]

    // 3. versioning via media type
    // send version information indide header
    // e.g header -->> accept   application/json;v=1.0 (client should send this way)
    // check startup.cs : options.ApiVersionReader = new MediaTypeApiVersionReader();
    [ApiVersion("1.0")]
    [Route("api/movies")]
    [ApiController]
    public class MovieV1Controller : ControllerBase
    {
        static List<MovieV1> movies = new List<MovieV1>()
        {
            new MovieV1()
            {
                Id = 0, MovieName = "movie 1"                
            },
            new MovieV1()
            {
                Id = 1, MovieName = "movie 2"
            }
        };

        // GET: api/Movie
        [HttpGet]
        public IEnumerable<MovieV1> Get()
        {
            return movies;
        }

        // GET: api/Movie/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Movie
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Movie/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
