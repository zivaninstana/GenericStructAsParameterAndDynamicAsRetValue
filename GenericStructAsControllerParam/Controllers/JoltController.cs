using arland.bmnext.cms.web.api.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GenericStructAsControllerParam.Controllers
{
    public struct DtoStruct
    {
        public long Id;
    }
    public class JoltController : AbstractWithOptionsDataApiController<Guid, DtoStruct>
    {
    }
}
