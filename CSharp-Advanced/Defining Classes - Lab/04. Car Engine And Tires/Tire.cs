using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
        int year;
        double pressure;

        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }

        public int Year { get; set; }

        public double Pressure { get; set; }

    }
}
