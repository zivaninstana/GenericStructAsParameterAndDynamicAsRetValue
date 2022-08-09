using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GenericStructAsControllerParam.Controllers
{
    [Route("api/[controller]")]
    public class TestController<TDtoOptions> : ApiController
        where TDtoOptions : struct
    {
        //GET: api/Test
       //[HttpGet]
       // public IEnumerable<string> Get()
       // {
       //     return new string[] { "value1", "value2" };
       // }

        //public IHttpActionResult GetByIdWithOptions(long id, TDtoOptions options) 
        //{
        //    return (IHttpActionResult)this.Ok("test");
        //}

        [HttpGet]
        //[Route("two/{id}")]
        // GET: api/Test/5
        public string Get(long id, TDtoOptions? idd = default)
        {
            return id.ToString() + "-" + idd.ToString();
        }

        // POST: api/Test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }
    }
}
