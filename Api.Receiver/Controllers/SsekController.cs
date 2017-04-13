using Api.Receiver.Models;
using SsekRoute.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Http;
using System.Xml;
using System.Xml.Serialization;
using SsekRoute.Factory;

namespace Api.Receiver.Controllers
{
    public class SsekController : ApiController
    {
        private ISSEKFactory _iFactory;

        public SsekController(ISSEKFactory iFactory)
        {
            _iFactory = iFactory;
        }

        public SsekController() : this(new SSEKFactory()) { }

        public IHttpActionResult Post([FromBody]string data)
        {
            var transaction = new Transaction();

            transaction = _iFactory.CreateObject(data);
                        
            return Ok(transaction);

            // försök skicka till service, returnera ett Receipt objekt med resultat?
        }
    }
}
