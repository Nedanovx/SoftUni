using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boardgames.DataProcessor.ImportDto
{
    public class ImportSellerDto
    {
        [JsonProperty("Name")]
        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string Name { get; set; }

        [JsonProperty("Address")]
        [Required]
        [MaxLength(30)]
        [MinLength(2)]
        public string Address { get; set; }

        [JsonProperty("Country")]
        [Required]
        public string Country { get; set; }

        [JsonProperty("Website")]
        [Required]
        [RegularExpression("www\\.[a-zA-Z\\d\\-]+\\.com")]
        public string Website { get; set; }

        
        public int[] Boardgames {  get; set; }
    }
}
