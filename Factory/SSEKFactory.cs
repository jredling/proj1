using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SsekRoute.Domain.Models;
using System.Xml.Serialization;
using System.IO;

namespace SsekRoute.Factory
{
    public class SSEKFactory : ISSEKFactory
    {
        public Transaction CreateObject(string data)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(Transaction));

               return (Transaction)serializer.Deserialize(new StringReader(data));
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {

            }
        }
        
        private XmlSerializer CreateOverrider()
        {
            // Create an XmlSerializer with overriding attributes.
            XmlAttributes attrs = new XmlAttributes();
            XmlAttributeOverrides xOver = new XmlAttributeOverrides();

            XmlRootAttribute xRoot = new XmlRootAttribute();
            // Set a new Namespace and ElementName for the root element.
            xRoot.Namespace = "http://schemas.ssek.org/ssek/2006-05-10/";
            xRoot.ElementName = "NewSSek";
            attrs.XmlRoot = xRoot;

            xOver.Add(typeof(Transaction), attrs);

            // Get the XmlAttributes object, based on the type.
            XmlAttributes tempAttrs;
            tempAttrs = xOver[typeof(Transaction)];

            XmlSerializer xSer = new XmlSerializer(typeof(Transaction), xOver);
            return xSer;
        }
    }
}
