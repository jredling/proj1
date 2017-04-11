using Api.Receiver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Serialization;

namespace Api.Receiver.Controllers
{
    public class SsekController : ApiController
    {
        // POST api/values
        public IHttpActionResult Post([FromBody]ParamsObject paramsObject)
        {
            return Ok(paramsObject);
        }
    }
}
