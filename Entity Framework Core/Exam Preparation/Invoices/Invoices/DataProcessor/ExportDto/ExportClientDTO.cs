using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.DataProcessor.ExportDto
{
    public class ExportClientDTO
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("NumberVat")]
        public string NumberVat {  get; set; }
    }
}
