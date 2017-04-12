using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SsekRoute.Models
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://schemas.ssek.org/ssek/2006-05-10/")]
    [XmlRoot(Namespace = "http://schemas.ssek.org/ssek/2006-05-10/", IsNullable = false)]
    public class FaultData
    {
        public string FaultingMessage { get; set; }
        public string TxId { get; set; }
        [XmlElement("FaultItem")]
        public List<FaultItems> FaultItems { get; set; }
    }

    public class FaultItems
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string System { get; set; }
    }
}