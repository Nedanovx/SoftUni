﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        string make;
        string model;
        int year;
        double fuelQuantity;
        double fuelConsumption;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
            
        }
        
        public Car(string make, string model, int year, double fuelQuantity, double fuelCosumption) : this(make, model,year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelCosumption;
        }

        public string Make { get { return make; } set { make = value; } }

        public string Model { get { return model; } set { model = value; } }

        public int Year { get { return year; } set { year = value; } }

        public double FuelQuantity { get { return fuelQuantity; } set {fuelQuantity = value; } }

        public double FuelConsumption { get { return fuelConsumption; } set {fuelConsumption = value; } }

        public void Drive (double distance)
        {
            if (fuelQuantity - (distance * fuelConsumption) / 100 > 0)
            {
                fuelQuantity -= ((distance * fuelConsumption) / 100);
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity:F2}";
        }

    }
}
