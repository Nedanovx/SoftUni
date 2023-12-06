using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Medicines.DataProcessor.ImportDtos
{
    [XmlType("Medicine")]
    public class ImportMedicineDto
    {
        [XmlAttribute("category")]
        [Required]
        public int Category { get; set; }

        [XmlElement("Name")]
        [MaxLength(150)]
        [MinLength(3)]
        [Required]
        public string Name { get; set; } = null!;

        [XmlElement("Price")]
        [Range(0.01, 1000.00)]
        [Required]
        public decimal Price { get; set; }

        [XmlElement("ProductionDate")]
        [Required]
        public string ProductionDate { get; set; } 

        [XmlElement("ExpiryDate")]
        [Required]
        public string ExpiryDate { get; set; } 

        [XmlElement("Producer")]
        [MaxLength(100)]
        [MinLength(3)]
        [Required]
        public string Producer { get; set; } = null!;
    }
}
