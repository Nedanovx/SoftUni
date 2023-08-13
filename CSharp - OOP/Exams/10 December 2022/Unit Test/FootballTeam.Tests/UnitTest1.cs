using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace FootballTeam.Tests
{
    public class Tests
    {
        private FootballTeam team;
        [SetUp]
        public void Setup()
        {            
        }
        [Test]
        public void CreatTeam()
        {
            FootballTeam team = new FootballTeam("Milan", 25);
            Assert.IsNotNull(team);
            Assert.AreEqual("Milan", team.Name);
            Assert.AreEqual(25,team.Capacity);
            Assert.AreEqual(team.Players.GetType(),typeof(List<FootballPlayer>));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void NameDoesNotNullOrEmpty(string name)
        {
            FootballTeam team;
            ArgumentException exception = Assert.Throws<ArgumentException>(()=>new FootballTeam(name,25));
            Assert.AreEqual(exception.Message, "Name cannot be null or empty!");
        }
        [Test]
        public void InvaliPlayerCapacity()
        {
            FootballTeam team;
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new FootballTeam("Milan", 14));
            Assert.AreEqual(exception.Message, "Capacity min value = 15");
        }
        [Test]
        public void TestPlayer()
        {
            FootballPlayer player = new FootballPlayer("Koko", 17, "Midfielder");
            Assert.IsNotNull(player);
            Assert.AreEqual("Koko", player.Name);
            Assert.AreEqual(17, player.PlayerNumber);
            Assert.AreEqual("Midfielder", player.Position);
        }
        [Test]
        public void TestAddPlayerNegative()
        {
            FootballPlayer player1 = new FootballPlayer("Koko", 1, "Midfielder");
            FootballPlayer player2 = new FootballPlayer("Koko", 1, "Midfielder");
            FootballPlayer player3 = new FootballPlayer("Koko", 2, "Midfielder");
            FootballPlayer player4= new FootballPlayer("Koko", 3, "Midfielder");
            FootballPlayer player5 = new FootballPlayer("Koko", 4, "Midfielder");
            FootballPlayer player6 = new FootballPlayer("Koko", 5, "Midfielder");
            FootballPlayer player7 = new FootballPlayer("Koko", 6, "Midfielder");
            FootballPlayer player8 = new FootballPlayer("Koko", 7, "Midfielder");
            FootballPlayer player9 = new FootballPlayer("Koko", 8, "Midfielder");
            FootballPlayer player10 = new FootballPlayer("Koko", 9, "Midfielder");
            FootballPlayer player11 = new FootballPlayer("Koko", 10, "Midfielder");
            FootballPlayer player12 = new FootballPlayer("Koko", 11, "Midfielder");
            FootballPlayer player13 = new FootballPlayer("Koko", 12, "Midfielder");
            FootballPlayer player14 = new FootballPlayer("Koko", 13, "Midfielder");
            FootballPlayer player15 = new FootballPlayer("Koko", 14, "Midfielder");
            FootballTeam team = new FootballTeam("Milan",15);
            team.AddNewPlayer(player1);
            team.AddNewPlayer(player2);
            team.AddNewPlayer(player3);
            team.AddNewPlayer(player4);
            team.AddNewPlayer(player5);
            team.AddNewPlayer(player6);
            team.AddNewPlayer(player7);
            team.AddNewPlayer(player8);
            team.AddNewPlayer(player9);
            team.AddNewPlayer(player10);
            team.AddNewPlayer(player11);
            team.AddNewPlayer(player12);
            team.AddNewPlayer(player13);
            team.AddNewPlayer(player14);
            team.AddNewPlayer(player15);
            FootballPlayer player16 = new FootballPlayer("Koko", 15, "Midfielder");
            string result = team.AddNewPlayer(player16);
            Assert.AreEqual(result, "No more positions available!");
        }
        [Test]
        public void AddPLayer()
        {
            FootballPlayer player15 = new FootballPlayer("Koko", 14, "Midfielder");
            FootballTeam team = new FootballTeam("Milan", 15);
            team.AddNewPlayer(player15);
            string result = team.AddNewPlayer(player15);
            Assert.AreEqual(result, "Added player Koko in position Midfielder with number 14");
        }
        [Test]
        public void PickPlayer()
        {
            FootballPlayer player14 = new FootballPlayer("Koko", 13, "Midfielder");
            FootballPlayer player15 = new FootballPlayer("Ivan", 14, "Midfielder");
            FootballTeam team = new FootballTeam("Milan", 15);
            team.AddNewPlayer(player14);
            team.AddNewPlayer(player15);
            FootballPlayer player = team.PickPlayer("Koko");
            Assert.AreEqual(player, player14);
        }
        [Test]
        public void Score()
        {
            FootballPlayer player14 = new FootballPlayer("Koko", 13, "Midfielder");
            FootballPlayer player15 = new FootballPlayer("Ivan", 14, "Midfielder");
            FootballTeam team = new FootballTeam("Milan", 15);
            team.AddNewPlayer(player14);
            team.AddNewPlayer(player15);
            string player = team.PlayerScore(13);
            Assert.AreEqual(player, "Koko scored and now has 1 for this season!");
        }
    }
}