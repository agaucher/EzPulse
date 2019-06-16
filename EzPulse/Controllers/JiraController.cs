using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EzPulse.Controllers
{
    public class JiraController : ApiController
    {
        // GET: api/Jira
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
