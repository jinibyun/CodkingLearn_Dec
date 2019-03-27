using HelloWebApi.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWebApi.Controller
{
    public class TitlesController : ApiController
    {
        [Route("api/Titles")]
        [HttpGet]
        public TitlesDTO Get()
        {
            var obj = new pubsRepository();
            var re = obj.GetTitles();
            return new TitlesDTO
            {
                advance = re.advance,
                price = re.price,
                pub_id = re.pub_id,
                type = re.type,
                TypePrice = re.type + " " + re.price.ToString()
            };
        }

        [Route("api/Titles/{titleId}")]
        public string GetTitle(string titleId)
        {
            return "title: " + titleId;
        }

        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "Hello Dodam";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}