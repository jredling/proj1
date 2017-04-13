using System;
using System.Xml.Serialization;

namespace SsekRoute.Domain.Models
{
    public class Receipt
    {
        public string ResponseCode { get; set; } = "Ok";
        public string ResponseMEssage { get; set; }
        public string RequestSignatureValue { get; set; }
    }
}