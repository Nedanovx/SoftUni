using Invoices.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Invoices.DataProcessor.ImportDto
{
    [XmlType("Client")]
    public class ImportClientDTO
    {
        [XmlElement("Name")]
        [Required]
        [MaxLength(25)]
        [MinLength(10)]
        public string Name { get; set; }

        [XmlElement("NumberVat")]
        [Required]
        [MaxLength(15)]
        [MinLength(10)]
        public string NumberVat { get; set; }

        [XmlArray("Addresses")]
        public ImportAddressDTO[] Addresses { get; set; } 
    }
}
