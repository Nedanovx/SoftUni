using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Trucks.Data.Models.Enums;

namespace Trucks.DataProcessor.ImportDto
{
    [XmlType("Truck")]
    public class ImportTruckDto
    {
        [XmlElement("RegistrationNumber")]
        [MaxLength(8)]
        [MinLength(8)]
        [RegularExpression("^[A-Z]{2}[0-9]{4}[A-Z]{2}$")]
        public string RegistrationNumber { get; set; } = null!;

        [XmlElement("VinNumber")]
        [Required]
        [MaxLength(17)]
        [MinLength(17)]
        public string VinNumber { get; set; } = null!;

        [XmlElement("TankCapacity")]
        [Required]
        [Range(950,1420)]
        public int TankCapacity { get; set; }

        [XmlElement("CargoCapacity")]
        [Required]
        [Range(5000, 29000)]

        public int CargoCapacity { get; set; }

        [XmlElement("CategoryType")]
        [EnumDataType(typeof(CategoryType))]
        [Required]
        [Range(0,3)]
        public int CategoryType { get; set; }

        [XmlElement("MakeType")]
        [EnumDataType(typeof(MakeType))]
        [Required]
        [Range(0,4)]
        public int MakeType { get; set; }
    }
}

