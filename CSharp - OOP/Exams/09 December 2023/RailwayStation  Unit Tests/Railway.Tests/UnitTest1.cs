namespace Railway.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateRailwayStation()
        {
            RailwayStation railwayStation = new RailwayStation("Sofia");
            Assert.IsNotNull(railwayStation);
            Assert.That(railwayStation.Name, Is.EqualTo("Sofia"));
            Assert.That(railwayStation.ArrivalTrains.Count, Is.EqualTo(0));
            Assert.That(railwayStation.DepartureTrains.Count, Is.EqualTo(0));
        }
        [Test]  
        public void CreateRailwayStationWithNullOrWhiteSpace()
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new RailwayStation(""));
            Assert.That(exception.Message, Is.EqualTo("Name cannot be null or empty!"));
        }
        [Test]
        public void CreateRailwayStationWithWhiteSpace()
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new RailwayStation("  "));
            Assert.That(exception.Message, Is.EqualTo("Name cannot be null or empty!"));
        }
        [Test]
        public void ShouldAddNewArrivalOnBoard()
        {
            RailwayStation railwayStation = new RailwayStation("Sofia");
            railwayStation.NewArrivalOnBoard("Varna");
            railwayStation.NewArrivalOnBoard("Ruse");
            Assert.That(railwayStation.Name, Is.EqualTo("Sofia"));
            Assert.That(railwayStation.ArrivalTrains.Count, Is.EqualTo(2));
            Assert.That(railwayStation.DepartureTrains.Count, Is.EqualTo(0));
        }
        [Test]
        public void TrainHasArrived()
        {
            RailwayStation railwayStation = new RailwayStation("Sofia");
            railwayStation.NewArrivalOnBoard("Varna");
            railwayStation.NewArrivalOnBoard("Ruse");
            string result = railwayStation.TrainHasArrived("Burgas");
            Assert.That(railwayStation.ArrivalTrains.Count, Is.EqualTo(2));
            Assert.That(railwayStation.DepartureTrains.Count, Is.EqualTo(0));
            Assert.That(result, Is.EqualTo("There are other trains to arrive before Burgas."));
        }
        [Test]
        public void TrainHasArrivedAndEnqueueToDepartureTrains()
        {
            RailwayStation railwayStation = new RailwayStation("Sofia");
            railwayStation.NewArrivalOnBoard("Varna");
            railwayStation.NewArrivalOnBoard("Plovdiv");
            railwayStation.NewArrivalOnBoard("Ruse");
            string result = railwayStation.TrainHasArrived("Varna");
            Assert.That(railwayStation.ArrivalTrains.Count, Is.EqualTo(2));
            Assert.That(railwayStation.DepartureTrains.Count, Is.EqualTo(1));
            Assert.That(railwayStation.ArrivalTrains.Peek(), Is.EqualTo("Plovdiv"));
            Assert.That(railwayStation.DepartureTrains.Peek(), Is.EqualTo("Varna"));
            Assert.That(result, Is.EqualTo("Varna is on the platform and will leave in 5 minutes."));
        }
        [Test]
        public void TrainHasLeftShouldReturnTrue()
        {
            RailwayStation railwayStation = new RailwayStation("Sofia");
            railwayStation.NewArrivalOnBoard("Varna");
            railwayStation.NewArrivalOnBoard("Plovdiv");
            railwayStation.NewArrivalOnBoard("Ruse");
            railwayStation.TrainHasArrived("Varna");
            railwayStation.TrainHasArrived("Plovdiv");
            Assert.That(railwayStation.TrainHasLeft("Varna"), Is.True);
            Assert.That(railwayStation.DepartureTrains.Count(), Is.EqualTo(1));
            Assert.That(railwayStation.DepartureTrains.Peek(), Is.EqualTo("Plovdiv"));
        }
        [Test]
        public void TrainHasLeftShouldReturnFalse()
        {
            RailwayStation railwayStation = new RailwayStation("Sofia");
            railwayStation.NewArrivalOnBoard("Varna");
            railwayStation.NewArrivalOnBoard("Plovdiv");
            railwayStation.NewArrivalOnBoard("Ruse");
            railwayStation.TrainHasArrived("Varna");
            railwayStation.TrainHasArrived("Plovdiv");
            Assert.That(railwayStation.DepartureTrains.Count(), Is.EqualTo(2));
            Assert.That(railwayStation.DepartureTrains.Peek(), Is.EqualTo("Varna"));
            Assert.That(railwayStation.TrainHasLeft("Ruse"), Is.False);
        }
    }
}