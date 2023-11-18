using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.DTOs.Import
{
    public class CarDTO
    {
        public CarDTO()
        {
            PartsId = new HashSet<int>();
        }
        public string Make { get; set; } = null!;

        public string Model { get; set; } = null!;

        public long TraveledDistance { get; set; }

        public virtual IEnumerable<int> PartsId { get; set; }
    }
}
