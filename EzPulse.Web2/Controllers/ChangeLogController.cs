using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EzPulse.Web2.Controllers
{
    public class ChangeLogController : ApiController
    {
        // GET: api/ChangeLog
        public IEnumerable<string> Get()
        {
            return new string[] { "IAT-1001: fjkdf dsjf djfkds ffjd", "IAT-1002: fdskf sdj fdjsfdslfd fldsj f" };
        }
    }
}
