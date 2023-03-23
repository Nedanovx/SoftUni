namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class WarriorTests
    {
        private Warrior warrior;
        [SetUp]
        public void Setup()
        {
            warrior = new Warrior("Nikola",100,100);
        }
        [TearDown]
        public void TearDown()
        {
            warrior = null;
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void IfNameIsNullOrEmptyOrWhitespaceMustThrow(string name)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(()=> new Warrior(name,100,100));
            Assert.AreEqual(exception.Message, "Name should not be empty or whitespace!");
        }

        [Test]
        [TestCase(-5)]
        [TestCase(0)]      
        public void ShouldThrowIfDamageIsNegativeValueOrZero(int damage)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Warrior("Nikola", damage, 100));
            Assert.AreEqual(exception.Message, "Damage value should be positive!");
        }

        [Test]
        public void ShouldThrowIfHpIsNegativeValue()
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Warrior("Nikola", 100, -9));
            Assert.AreEqual(exception.Message, "HP should not be negative!");
        }

        [Test]
        [TestCase(30)]
        [TestCase(25)]
        public void ShouldThrowIfWarriorHaveLessHpThanMinWhenAttack(int hp)
        {
            Warrior hero = new Warrior("Ivan", 68, hp);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => hero.Attack(warrior));

            Assert.AreEqual(exception.Message, "Your HP is too low in order to attack other warriors!");

        }

        [Test]
        [TestCase(30)]
        [TestCase(25)]
        public void ShouldThrowIfWarriorHaveLessHpThanMinWhenAttackedHim(int hp)
        {
            Warrior hero = new Warrior("Ivan", 68, hp);
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => warrior.Attack(hero));
            Assert.AreEqual(exception.Message, "Enemy HP must be greater than 30 in order to attack him!");
        }

        [Test]
        public void ShouldThrowIfWarriorHaveLessHpThanHisOponentDamage()
        {
            Warrior hero = new Warrior("Ivan", 68, 62);
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => hero.Attack(warrior));
            Assert.AreEqual(exception.Message, "You are trying to attack too strong enemy");
        }

        [Test]
        public void TestAttack()
        {
            Warrior hero = new Warrior("Ivan", 50, 140);
            warrior.Attack(hero);
            Assert.AreEqual(40, hero.HP);
        }
        [Test]
        public void TestAttackShouldKill()
        {
            Warrior hero = new Warrior("Ivan", 50, 90);
            warrior.Attack(hero);
            Assert.AreEqual(0, hero.HP);
        }
    }
}