namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {
        private Car car;
        [SetUp]
        public void Setup()
        {
            car = new Car("Opel","Astra", 7, 50);
        }
        [TearDown]
        public void TearDown()
        {
            car = null;
        }

        [Test]
        public void CreateCar()
        {
            car = new Car("Opel", "Astra", 7, 50);

            Assert.AreEqual("Opel", car.Make);
            Assert.AreEqual("Astra", car.Model);
            Assert.AreEqual(7, car.FuelConsumption);
            Assert.AreEqual(50,car.FuelCapacity);
            Assert.AreEqual(0, car.FuelAmount);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void CreateCarFailsWhenMakelIsNullOrEmpty(string make)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Car(make, "Astra",7,50));
            Assert.AreEqual(exception.Message, "Make cannot be null or empty!");
        }       

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void CreateCarFailsWhenModelIsEmptyOrNull(string model)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Car("Opel", model, 7, 50));
            Assert.AreEqual(exception.Message, "Model cannot be null or empty!");
        }
       
        [Test]
        [TestCase(0)]
        [TestCase(-8)]
        public void FuelConsumptionShouldTrowWithZeroOrNegativeValue(double fuelConsumption)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Car("Opel", "Astra", fuelConsumption, 50));
            Assert.AreEqual(exception.Message, "Fuel consumption cannot be zero or negative!");
        }

        [Test]
        [TestCase(0)]
        [TestCase(-8)]
        public void FuelCapacityShouldTrowWithZeroOrNegativeValue(double fuelCapacity)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Car("Opel", "Astra", 7, fuelCapacity));
            Assert.AreEqual(exception.Message, "Fuel capacity cannot be zero or negative!");
        }

        [Test]
        [TestCase(0)]
        [TestCase(-8)]
        public void RefuelShouldTrowWithZeroOrNegativeValue(double refuel)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => car.Refuel(refuel));
            Assert.AreEqual(exception.Message, "Fuel amount cannot be zero or negative!");
        }

        [Test]
        public void RefuelShouldBeEqualToAmount()
        {
            car.Refuel(25);
            Assert.AreEqual(25,car.FuelAmount);
        }

        [Test]
        public void RefuelShouldBeOrEqualTpCapacity()
        {
            car.Refuel(100);
            Assert.AreEqual(50,car.FuelAmount);
        }

        [Test]
        public void DriveShouldThrow()
        {
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => car.Drive(1));
            Assert.AreEqual(exception.Message, "You don't have enough fuel to drive!");
        }

        [Test]
        public void Drive()
        {
            car.Refuel(10);
            car.Drive(100);
            Assert.AreEqual(3,car.FuelAmount);
        }
    }
}