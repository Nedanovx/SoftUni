using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Cargo
    {
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;          
        }

        public string Type { get; set; }

        public int Weight { get; set; }
    }
}
