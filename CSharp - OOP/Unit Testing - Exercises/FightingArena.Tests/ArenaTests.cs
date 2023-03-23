namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System.Threading;
    using System;

    [TestFixture]
    public class ArenaTests
    {
        private Arena arena;
        [SetUp]
        public void Setup()
        {
            arena = new Arena();
        }
        [TearDown]
        public void TearDown()
        {
            arena = null;
        }

        [Test]
        public void ArenaShouldBeVoidOnCreate()
        {
            Assert.AreEqual(0, arena.Count);
        }

        [Test]
        public void EnrollShouldAddWarrior()
        {
            arena.Enroll(new Warrior("Nikola", 50, 80));
            Assert.AreEqual(1, arena.Count);
        }

        [Test]
        public void EnrollShouldThrowIfWarriorNameIsNotUnique()
        {
            arena.Enroll(new Warrior("Nikola", 50, 80));
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => arena.Enroll(new Warrior("Nikola",62, 70)));
            Assert.AreEqual(exception.Message, "Warrior is already enrolled for the fights!");
        }

        [Test]        
        public void FightShoulThrowIfDefenderIsMissing()
        {
            arena.Enroll(new Warrior("Nikola", 50, 80));
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => arena.Fight("Nikola", "Ivan"));
            Assert.AreEqual(exception.Message, "There is no fighter with name Ivan enrolled for the fights!");
        }

        [Test]
        public void FightShoulThrowIfAttackerIsMissing()
        {
            arena.Enroll(new Warrior("Nikola", 50, 80));
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => arena.Fight("Ivan", "Nikola"));
            Assert.AreEqual(exception.Message, "There is no fighter with name Ivan enrolled for the fights!");
        }

        [Test]
        public void TestFight()
        {
            var attacker = new Warrior("Nikola", 15, 35);
            var defender = new Warrior("Ivan", 15, 45);
            arena.Enroll(defender);
            arena.Enroll(attacker);
            arena.Fight(attacker.Name, defender.Name);
            Assert.AreEqual(30, defender.HP);
            Assert.AreEqual(20, attacker.HP);
        }
    }
}
