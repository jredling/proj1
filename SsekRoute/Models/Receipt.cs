using System;
using System.Xml.Serialization;

namespace SsekRoute.Models
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://schemas.ssek.org/ssek/2006-05-10/")]
    [XmlRoot(Namespace = "http://schemas.ssek.org/ssek/2006-05-10/", IsNullable = false)]
    public class Receipt
    {
        public string ResponseCode { get; set; } = "Ok";
        public string ResponseMEssage { get; set; }
        public string RequestSignatureValue { get; set; }
    }
}