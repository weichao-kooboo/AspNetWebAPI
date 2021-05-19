using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ASPNETRoute.Controller
{
    public class DemoController:ApiController
    {
        [Route("api/demo/{foo}/{bar}/{baz}")]
        public Tuple<string,int,int?> Get(string foo,int bar,int? baz)
        {
            return new Tuple<string, int, int?>(foo, bar, baz);
        }
    }
}