using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

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

        [HttpPost]
        [Route("student/names/{id}")]
        public IHttpActionResult getdata(int id)
        {
            return Ok("Yash" + id);
        }
        
        
        
        [HttpPost]
        [Route("student/names/{id}")]
        public IHttpActionResult getdata(int id)
        {
            var re = Request;
            var headers = re.Headers;
            var Data = String.Empty;
            if (headers.Contains("token"))
            {
                string token = headers.GetValues("token").First();
                Data = token;
            }

            
            return Ok(Data);
        }
    }
}
