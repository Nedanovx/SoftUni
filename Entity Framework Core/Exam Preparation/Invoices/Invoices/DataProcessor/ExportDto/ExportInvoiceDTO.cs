using Invoices.Data.Models.Enums;
using System.Xml.Serialization;

namespace Invoices.DataProcessor.ExportDto
{
    [XmlType("Invoice")]
    public class ExportInvoiceDTO
    {
        [XmlElement("InvoiceNumber")]
        public int InvoiceNumber { get; set; }

        [XmlElement("InvoiceAmount")]
        public decimal InvoiceAmount { get; set; }

        [XmlElement("DueDate")]
        public string DueDate { get; set; }

        [XmlElement("Currency")]
        public string Currency { get; set; }
    }
}