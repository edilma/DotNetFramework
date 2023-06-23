using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCTest.Controllers
{
    public class ValuesController : ApiController
    {
        //Create an Endpoint GetStuff
        [HttpGet]
        [Route("api/values/GetStuff")]
        public string GetStuff()
        {
            return "Hello World";
        }



        // GET api/values
        //create a endpoint route to get all values
        [HttpGet]
        [Route("api/values/GetAllValues")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        
        [HttpGet]
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
