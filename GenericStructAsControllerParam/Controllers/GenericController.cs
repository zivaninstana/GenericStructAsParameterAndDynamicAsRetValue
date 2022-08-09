using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GenericStructAsControllerParam.Controllers
{
    public class GenericController : ApiController
    {
        [NonAction]
        protected dynamic Execute(Func<dynamic> call)
        {
            try
            {
                return call();
            }
            catch (Exception bex)
            {
                return new { Messages = new[] { new { Severity = "Error", Message = bex.Message } } };
            }
        }



        [HttpPost]
        public dynamic ListApprovalDetails(Param1<TestString> p1)
        {
            return Execute(() =>
            {
                dynamic result = new System.Dynamic.ExpandoObject();

                //throw new Exception("test ex");

                result.Property1 = 10;
                result.Property2 = p1.Field1?.S;
                result.Property3 = false;

                return result;
            });
        }
    }

    public struct Param1<T>
    {
        public T Field1 { get; set; }
    }

    public class TestString
    {
        public string S { get; set; }
    }
}
