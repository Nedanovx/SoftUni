using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Invoices.DataProcessor.ImportDto
{
    [XmlType("Address")]
    public class ImportAddressDTO
    {
        [XmlElement("StreetName")]
        [Required]
        [MaxLength(20)]
        [MinLength(10)]
        public string StreetName { get; set; }

        [XmlElement("StreetNumber")]
        [Required]
        public int StreetNumber { get; set; }

        [XmlElement("PostCode")]
        [Required]
        public string PostCode { get; set; }

        [XmlElement("City")]
        [Required]
        [MaxLength(15)]
        [MinLength(5)]
        public string City { get; set; }

        [XmlElement("Country")]
        [Required]
        [MaxLength(15)]
        [MinLength(5)]
        public string Country { get; set; }
    }
}
