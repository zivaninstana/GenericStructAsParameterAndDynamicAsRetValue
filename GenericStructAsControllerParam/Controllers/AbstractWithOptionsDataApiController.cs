using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace arland.bmnext.cms.web.api.controller
{
    public class AbstractWithOptionsDataApiController<TDtoOptions, TDto> : ApiController
      where TDtoOptions : struct
    {
        [HttpGet]
        public IHttpActionResult Get(long id, TDtoOptions options)
        {
            return (IHttpActionResult)this.Ok<TDto>((TDto)((object)"test"));
        }

        [HttpGet]
        public IHttpActionResult GetAllWithOptions(TDtoOptions options, [FromUri] string orderBy = null)
        {
            return (IHttpActionResult)this.Ok<TDto>((TDto)((object)"all_test"));
        }
    }
}
