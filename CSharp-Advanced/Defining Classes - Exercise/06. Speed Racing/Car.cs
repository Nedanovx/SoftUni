using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        string model;

        double fuelAmount;

        double fuelConsumptionPerKilometer;

        int kilometer;

        //double Travelleddistance;

        public Car (string model,double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            
        }
        public string Model { get { return model; } set { model = value; } }

        public double FuelAmount { get { return fuelAmount; } set { fuelAmount = value; } }

        public double FuelConsumptionPerKilometer { get { return fuelConsumptionPerKilometer; } set { fuelConsumptionPerKilometer = value; } } 

        public int Kilometer { get { return kilometer; } set { kilometer = value; } }
        public void Drive(int distance)
        {
            if(fuelAmount -(distance*fuelConsumptionPerKilometer) >= 0)
            {
                fuelAmount -= distance*fuelConsumptionPerKilometer;
                kilometer += distance;
                
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
