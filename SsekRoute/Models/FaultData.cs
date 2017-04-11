using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace SsekRoute.Models
{
    public class FaultData
    {
        public string FaultingMessage { get; set; }
        public string TxId { get; set; }
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