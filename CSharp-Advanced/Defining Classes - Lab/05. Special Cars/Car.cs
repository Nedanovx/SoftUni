using System;

namespace CarManufacturer
{
    public class Car
    {
        public Car (string make, string model, int year, double fuelQuantity, double fuelCosumption, Engine engine, Tire[] tires)
        {
            Make = make;
            Model = model;
            Year = year;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelCosumption;
            Engine = engine;
            Tires = tires;
        }

        public Engine Engine { get; set; }

        public Tire[] Tires { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public void Drive (double distance)
        {
            if(FuelQuantity - ((distance * FuelConsumption)/100) > 0)
            {
                FuelQuantity -= ((distance * FuelConsumption)/100);
            }
            
        }     

    }
}
