using System;
using System.Xml.Serialization;

namespace SsekRoute.Models
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://schemas.ssek.org/ssek/2006-05-10/")]
    [XmlRoot(Namespace = "http://schemas.ssek.org/ssek/2006-05-10/", IsNullable = false)]
    public class SSek
    {
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
        public string MyProperty { get; set; }
    }
}