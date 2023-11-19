using System.Xml.Serialization;

namespace CarDealer.DTOs.Import
{
    [XmlType("partId")]
    public class PartIdDTO
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
    }
}