using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boardgames.DataProcessor.ExportDto
{
    public class ExportSellerDto
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Website")]
        public string Website { get; set; }

        [JsonProperty("Boardgames")]
        public ExportBoardgameDto[] Boardgames { get; set; }
    }
}
