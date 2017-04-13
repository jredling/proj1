using System;
using System.Xml.Serialization;

namespace SsekRoute.Domain.Models
{
    [XmlType("SSEK")]
    //[XmlType(AnonymousType = true, Namespace = "http://schemas.ssek.org/ssek/2006-05-10/")]
    //[XmlRoot(Namespace = "http://schemas.ssek.org/ssek/2006-05-10/", IsNullable = false)]
    public class Transaction
    {
        [XmlAttribute("AsyncMethod")]
        public string Method { get; set; }
        [XmlElement("SenderId")]
        public Sender Sender { get; set; }
        [XmlElement("ReceiverId")]
        public Receiver Receiver { get; set; }
        public string TxId { get; set; }
    }

    public class Sender
    {
        [XmlAttribute("TypeId")]
        public string Type { get; set; }

        [XmlText]
        public string SenderName { get; set; }
    }

    public class Receiver
    {
        [XmlAttribute("TypeId")]
        public string Type { get; set; }

        [XmlText]
        public string ReceiverName { get; set; }
    }
}