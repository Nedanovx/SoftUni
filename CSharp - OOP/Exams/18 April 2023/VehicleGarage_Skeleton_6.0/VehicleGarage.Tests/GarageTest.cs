using NUnit.Framework;
using System.Linq;

namespace VehicleGarage.Tests
{
    public class GarageTest
    {

        [Test]
        public void IsConstructorCreateGarageCorrect()
        {
            Garage garage = new Garage(5);
            Assert.AreEqual(5, garage.Capacity);
            Assert.IsNotNull(garage.Vehicles);
        }
        [Test]
        public void AddVehicleShouldAddIfGarageHaveEnoughCapacityAndVehicleDoesNotExist()
        {
            Garage garage = new Garage(5);
            Vehicle vehicle = new Vehicle("Opel", "Astra", "CB5219KK");
            var result = garage.AddVehicle(vehicle);
            Assert.True(result);
            Assert.Contains(vehicle, garage.Vehicles);
        }
        [Test]
        public void AddVehicleShouldReturnFalseIfVehicleAlreadyExist()
        {
            Garage garage = new Garage(5);
            Vehicle vehicle = new Vehicle("Opel", "Astra", "CB5219KK");
            garage.AddVehicle(vehicle);
            var result = garage.AddVehicle(vehicle);

            Assert.IsFalse(result);
        }
        [Test]
        public void AddVehicleShouldReturnFalseIfGarageDoesNotHaveEnoughCapacity()
        {
            Garage garage = new Garage(1);
            Vehicle vehicle1 = new Vehicle("Opel", "Astra", "CB5219KK");
            garage.AddVehicle(vehicle1);
            Vehicle vehicle2 = new Vehicle("Audi", "TT", "BT1247AA");
            var result = garage.AddVehicle(vehicle2);
            var contains = garage.Vehicles.Any(x => x.Brand == vehicle2.Brand && x.Model == vehicle2.Model &&
            x.LicensePlateNumber == vehicle2.LicensePlateNumber);
            Assert.IsFalse(result);
            Assert.IsFalse(contains);
        }
        [Test]
        public void ChargeVehiclesShouldChargeAllVehiclesUnderTheValue()
        {
            Garage garage = new Garage(10);
            Vehicle vehicle1 = new Vehicle("Opel", "Astra", "CB5219KK");
            garage.AddVehicle(vehicle1);
            Vehicle vehicle2 = new Vehicle("BMW", "X5", "CB5318KK");
            garage.AddVehicle(vehicle2);
            Vehicle vehicle3 = new Vehicle("Audi", "А6", "EH4589AA");
            garage.AddVehicle(vehicle3);
            Vehicle vehicle4 = new Vehicle("Opel", "Corsa", "BT3354TA");
            garage.AddVehicle(vehicle4);
            
            garage.DriveVehicle(vehicle1.LicensePlateNumber, 90, false);
            garage.DriveVehicle(vehicle2.LicensePlateNumber, 80, false);
            garage.DriveVehicle(vehicle3.LicensePlateNumber, 50, false);
            garage.DriveVehicle(vehicle4.LicensePlateNumber, 10, false);

            var result = garage.ChargeVehicles(50);
            Assert.AreEqual(3, result);
            Assert.AreEqual(100, vehicle1.BatteryLevel);
            Assert.AreEqual(100, vehicle2.BatteryLevel);
            Assert.AreEqual(100, vehicle3.BatteryLevel);
            Assert.AreEqual(90, vehicle4.BatteryLevel);
        }
        [Test]
        public void DriveVehicleShouldNotMoveIfBatteryDrainageIsAbove100OrHigherOfOurBattery()
        {
            Garage garage = new Garage(10);
            Vehicle vehicle1 = new Vehicle("Opel", "Astra", "CB5219KK");
            garage.AddVehicle(vehicle1);
            Vehicle vehicle2 = new Vehicle("BMW", "X5", "CB5889KK");
            garage.AddVehicle(vehicle2);
            

            garage.DriveVehicle(vehicle1.LicensePlateNumber, 150, false);
            Assert.AreEqual(100, vehicle1.BatteryLevel);
            Assert.IsFalse(vehicle1.IsDamaged);
        }
        [Test]
        public void DriveVehicleShouldNotMoveIfVehicleIsDamaged()
        {
            Garage garage = new Garage(10);
            Vehicle vehicle1 = new Vehicle("Opel", "Astra", "CB5219KK");
            garage.AddVehicle(vehicle1);
            Vehicle vehicle2 = new Vehicle("BMW", "X5", "CB5319KK");
            garage.AddVehicle(vehicle2);

            garage.DriveVehicle(vehicle1.LicensePlateNumber, 20, true);
            garage.DriveVehicle(vehicle1.LicensePlateNumber, 10, true);
            Assert.AreEqual(80, vehicle1.BatteryLevel);
            Assert.IsTrue(vehicle1.IsDamaged);        
            Assert.IsFalse(vehicle2.IsDamaged);
        }
        [Test]
        public void DriveVehicleShouldNotMoveIfVehicleDoesNotHaveEnoughBattery()
        {
            Garage garage = new Garage(10);
            Vehicle vehicle1 = new Vehicle("Opel", "Astra", "CB5219KK");
            garage.AddVehicle(vehicle1);
            Vehicle vehicle2 = new Vehicle("BMW", "X5", "CB5319KK");
            garage.AddVehicle(vehicle2);
           
            garage.DriveVehicle(vehicle1.LicensePlateNumber, 50, false);
            garage.DriveVehicle(vehicle1.LicensePlateNumber, 60, false);
            Assert.AreEqual(50, vehicle1.BatteryLevel);
            Assert.IsFalse(vehicle1.IsDamaged);
        }
        [Test]
        public void RepairVehiclesShouldRepairAllBrokeVehicle()
        {
            Garage garage = new Garage(10);
            Vehicle vehicle1 = new Vehicle("Opel", "Astra", "CB5219KK");
            garage.AddVehicle(vehicle1);
            Vehicle vehicle2 = new Vehicle("BMW", "X5", "CB5319KK");
            garage.AddVehicle(vehicle2);
            Vehicle vehicle3 = new Vehicle("Audi", "А6", "EH4589AA");
            garage.AddVehicle(vehicle3);
            Vehicle vehicle4 = new Vehicle("Opel", "Corsa", "BT3354TA");
            garage.AddVehicle(vehicle4);

            garage.DriveVehicle(vehicle1.LicensePlateNumber, 50, true);
            garage.DriveVehicle(vehicle4.LicensePlateNumber, 80, true);

            var result = garage.RepairVehicles();
            Assert.IsFalse(vehicle1.IsDamaged);
            Assert.IsFalse(vehicle4.IsDamaged);
            Assert.AreEqual("Vehicles repaired: 2", result);
        }
    }
}