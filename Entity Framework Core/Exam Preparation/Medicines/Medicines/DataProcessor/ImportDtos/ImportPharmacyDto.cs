using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Medicines.DataProcessor.ImportDtos
{
    [XmlType("Pharmacy")]
    public class ImportPharmacyDto
    {
        [XmlAttribute("non-stop")]

        public string IsNonStop {  get; set; } = null!;

        [XmlElement("Name")]
        [MaxLength(50)]
        [MinLength(2)]

        public string Name { get; set; } = null!;

        [XmlElement("PhoneNumber")]
        [MaxLength(14)]
        [MinLength(14)]
        [RegularExpression("\\(\\d{3}\\) \\d{3}-\\d{4}")]
        public string PhoneNumber { get; set; } = null!;

        [XmlArray("Medicines")]
        public ImportMedicineDto[] Medicines { get; set; } = null!;
    }
}
