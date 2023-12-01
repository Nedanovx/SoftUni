using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footballers.DataProcessor.ImportDto
{
    public class ImportTeamDto
    {
        [JsonProperty("Name")]
        [MaxLength(40)]
        [MinLength(3)]
        [RegularExpression("[a-zA-Z0-9\\.\\-\\s]{3,}")]
        public string Name { get; set; } = null!;

        [JsonProperty("Nationality")]
        [MaxLength(40)]
        [MinLength(2)]
        public string Nationality { get; set; } = null!;

        [JsonProperty("Trophies")]
        public int Trophies { get; set; }

        
        public int[] Footballers { get; set; } = null!;
    }
}
