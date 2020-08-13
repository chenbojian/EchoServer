using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace EchoServer.Controllers
{
    public class EchoController : ApiController
    {
        [HttpGet]
        [Route("")]
        public Dictionary<string, string> Index()
        {
            var headers = Request.Headers;
            return Request.Headers.ToDictionary(h =>h.Key, h => string.Join(",", h.Value));
        }
    }
}