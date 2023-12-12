using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace MVCWithXMLFile.Models
{
    [Serializable]
    [XmlRoot("Product"), XmlType("Product")]
    public class Product
    {
        public string to { get; set; }
        public string from { get; set; }
        public string heading { get; set; }
        public string body { get; set; }

        public byte[] data { get; set; }
    }
}