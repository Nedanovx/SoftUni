using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicines.DataProcessor.ImportDtos
{
    public class ImportPatientDto
    {
        [JsonProperty("FullName")]
        [MaxLength(100)]
        [MinLength(5)]
        [Required]
        public string FullName { get; set; } = null!;

        [JsonProperty("AgeGroup")]
        [Range(0, 2)]
        [Required]
        public int AgeGroup { get; set; }

        [JsonProperty("Gender")]
        [Range(0,1)]
        [Required]
        public int Gender { get; set; }

        public int[] Medicines{ get; set; } = null!;
    }
}
