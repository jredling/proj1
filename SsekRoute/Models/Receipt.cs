using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SsekRoute.Models
{
    public class Receipt
    {
        public string ResponseCode { get; set; }
        public string ResponseMEssage { get; set; }
        public string RequestSignatureValue { get; set; }
    }
}