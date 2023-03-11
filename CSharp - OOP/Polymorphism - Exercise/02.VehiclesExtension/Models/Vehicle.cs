using VehiclesExtension.Models.Interfaces;

namespace VehiclesExtension.Models
{
    public class Vehicle : IVehicle
    {
        private double increasedConsumption;
        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity, double increasedConsumption) 
        {
            FuelQuantity = fuelQuantity > tankCapacity ?0:fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
            this.increasedConsumption = increasedConsumption;
        }
        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

        public double TankCapacity { get; private set; }

        public string Drive(double distance, bool isAirConditionerIsTurnedOn = true)
        {
            double totalComsumption;
            if(!isAirConditionerIsTurnedOn)
            {
                totalComsumption = FuelConsumption;
            }
            else
            {
                totalComsumption = FuelConsumption + increasedConsumption;
            }

            if(FuelQuantity < distance * totalComsumption)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            FuelQuantity -= distance * totalComsumption;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if(FuelQuantity + amount > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {amount} fuel in the tank");
            }
            FuelQuantity += amount;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
