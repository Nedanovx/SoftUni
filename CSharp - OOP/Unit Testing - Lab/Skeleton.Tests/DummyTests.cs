using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLossesHealthIfAttacked()
        {
            Dummy dummy = new Dummy(10, 10);
            dummy.TakeAttack(5);
            Assert.AreEqual(5, dummy.Health);
        }

        [Test]
        public void CanNotAttackDeadDummy()
        {
            Dummy dummy = new Dummy(0, 10);
            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(3));
        }

        [Test]
        public void DeadDummyGiveXp()
        {
            Dummy dummy = new Dummy(0, 10);
            int experience = dummy.GiveExperience();
            Assert.AreEqual(10, experience);
        }

        [Test]
        public void AliveDummyCanNotGiveXp()
        {
            Dummy dummy =new Dummy(4,10);
            
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}