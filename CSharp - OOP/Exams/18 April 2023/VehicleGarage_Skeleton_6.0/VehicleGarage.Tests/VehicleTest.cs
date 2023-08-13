using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleGarage.Tests
{
    public class VehicleTest
    {
        [Test]
        public void ConstructorVehicle()
        {
            Vehicle vehicle = new Vehicle("Opel", "Astra", "CB5219KK");
            Assert.AreEqual(vehicle.Brand, "Opel");
            Assert.AreEqual(vehicle.Model, "Astra");
            Assert.AreEqual(vehicle.LicensePlateNumber, "CB5219KK");
            Assert.IsFalse(vehicle.IsDamaged);
            Assert.AreEqual(vehicle.BatteryLevel, 100);

        }
    }
}
