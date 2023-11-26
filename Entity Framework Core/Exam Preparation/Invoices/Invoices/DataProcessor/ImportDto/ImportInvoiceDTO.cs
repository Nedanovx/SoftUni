using Invoices.Data.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.DataProcessor.ImportDto
{
    public class ImportInvoiceDTO
    {
        [JsonProperty("Number")]
        [Required]
        [Range(1000000000, 1500000000)]
        public int Number { get; set; }

        [JsonProperty("IssueDate")]
        [Required]
        public string IssueDate { get; set; }

        [JsonProperty("DueDate")]
        [Required]
        public string DueDate { get; set; }

        [JsonProperty("Amount")]
        [Required]
        public decimal Amount { get; set; }

        [JsonProperty("CurrencyType")]
        [Required]
        [EnumDataType(typeof(CurrencyType))]
        public CurrencyType CurrencyType { get; set; }

        [JsonProperty("ClientId")]
        [Required]
        public int ClientId { get; set; }
    }
}
