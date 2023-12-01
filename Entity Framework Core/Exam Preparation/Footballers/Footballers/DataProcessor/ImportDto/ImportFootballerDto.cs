using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Footballers.DataProcessor.ImportDto
{
    [XmlType("Footballer")]
    public class ImportFootballerDto
    {
        [XmlElement("Name")]
        [MaxLength(40)]
        [MinLength(2)]
        public string Name { get; set; } = null!;

        [XmlElement("ContractStartDate")]
        public string ContractStartDate { get; set; } = null!;

        [XmlElement("ContractEndDate")]

        public string ContractEndDate { get; set; } = null!;

        [XmlElement("BestSkillType")]
        public int BestSkillType { get; set; }

        [XmlElement("PositionType")]
        public int PositionType { get; set; }
    }
}
