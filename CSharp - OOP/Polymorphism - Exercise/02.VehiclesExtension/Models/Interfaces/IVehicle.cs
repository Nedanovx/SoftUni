namespace VehiclesExtension.Models.Interfaces
{
    public interface IVehicle
    {
        public double FuelQuantity { get; }
        public double FuelConsumption { get; }
        public double TankCapacity { get; }

        public string Drive(double distance, bool isAirConditionerIsTurnedOn = true);

        public void Refuel(double amount);
    }
}
