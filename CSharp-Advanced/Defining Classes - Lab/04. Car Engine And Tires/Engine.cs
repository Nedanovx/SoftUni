using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        int horsePower;
        double cubicCapacity;

        public Engine(int horspower, double cubicCapacity)
        {
            HorsePower = horspower;
            CubicCapacity = cubicCapacity;
        }

        public int HorsePower { get; set; }

        public double CubicCapacity { get; set; }
    }
}
