using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EzPulse.Web2.Controllers
{
    public class ApplicationsController : ApiController
    {
        [HttpGet()]
        public IEnumerable<string> Get()
        {
            return new string[] { "IA3", "Markview", "MyX" };
        }
    }
}
