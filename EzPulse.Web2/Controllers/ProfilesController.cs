using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EzPulse.Web2.Controllers
{
    [RoutePrefix("profiles")]
    public class ProfilesController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(new List<string> { "some results collection" });
        }

        public string[] Get(string id)
        {
            switch (id)
            {
                case "IA3":
                    return new string[] { "Classical", "Tactical" };

                case "Markview":
                    return new string[] { "Standard" };

                case "MyX":
                    return new string[] { };

                default:
                    return new string[] { };
            }
        }
    }
}
