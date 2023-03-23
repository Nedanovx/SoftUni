using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {

        [Test]
        public void AxeLossesDurabilityAfterAttack()
        {
            Axe axe = new Axe(10,10);
            Dummy dummy = new Dummy(10,10);

            axe.Attack(dummy);

            Assert.AreEqual(9,axe.DurabilityPoints);
        }

        [Test]
        public void TestAttackWithBrokenAxe()
        {
            Axe axe = new Axe(10, 0);
            Dummy dummy = new Dummy(10, 10);

            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
    }
}