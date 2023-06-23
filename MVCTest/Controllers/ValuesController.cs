using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCTest.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        //Get api/values/GetStuff
        [HttpGet]
        [Route("GetStuff")]
        public string GetStuff()
        {
            return "Hello World";
        }

        // GET api/values/GetAllValues
        [HttpGet]
        [Route("GetAllValues")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        
        // GET api/values/5
        [HttpGet]
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
