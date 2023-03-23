namespace Database.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        private Database testArray;

        [SetUp]
        public void Setup()
        {
            testArray = new Database();
        }

        [TearDown]
        public void TearDown()
        {
            testArray = null;
        }

        [Test]
        public void TestAddMethod()
        {
            testArray.Add(7);
            int[] result = testArray.Fetch();

            Assert.AreEqual(1, testArray.Count);

            Assert.AreEqual(7, result[0]);

            Assert.AreEqual(1, result.Length);
        }

        [Test]
        public void ShouldThrowIfElementsAreMoreThenMaximumLenght()
        {
            testArray = new Database(1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => testArray.Add(17));

            Assert.AreEqual(exception.Message, "Array's capacity must be exactly 16 integers!");
        }      

        [Test]
        public void RemoveElements()
        {
            testArray = new Database(7,9);
            testArray.Remove();
            int[] result = testArray.Fetch();
            
            Assert.AreEqual(1, testArray.Count);          
            
            Assert.AreEqual(7, result[0]);
            
            Assert.AreEqual(1,result.Length);
        }

        [Test]
        public void ShouldThrowWhenRemoveElementWithZeroArrayLenght()
        {
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => testArray.Remove());
            Assert.AreEqual(exception.Message, "The collection is empty!");
        }

        [Test]
        public void TestFetch()
        {
            testArray = new Database(1, 2, 3);

            int[] result = testArray.Fetch();
            
            Assert.That(new int[] {1,2,3}, Is.EquivalentTo(result));
        }
    }
}
