using Boardgames.Data.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ExportDto
{
    
    public class ExportBoardgameDto
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Rating")]
        public double Rating { get; set; }

        [JsonProperty("Mechanics")]
        public string Mechanics { get; set; }

        [JsonProperty("Category")]
        public string Category { get; set; }
    }
}
