namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private Database database;
        [SetUp]
        public void Setup()
        {
            database = new Database();
        }

        [TearDown]
        public void TearDown()
        {
            database = null;
        }

        
        [Test]
        public void TestAddMethod()
        {
            database.Add(new Person(1, "Gosho"));
            Person result = database.FindById(1);

            Assert.AreEqual(1, database.Count);

            Assert.AreEqual(1, result.Id);

            Assert.AreEqual("Gosho", result.UserName);
        }

        [Test]
        public void ShouldThrowIfElementsAreMoreThenMaximumLenght()
        {
            Person[] people = CreateFullArray();
            database = new Database(people);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>
                (()=>database.Add(new Person(17, "Gosho")));

            Assert.AreEqual(exception.Message, "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void ShouldTrhowIfUsernameIsNotUnique()
        {
            database.Add(new Person(1, "Gosho"));
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>
                (() => database.Add(new Person(17, "Gosho")));
            Assert.AreEqual(exception.Message, "There is already user with this username!");
        }

        [Test]
        public void ShouldTrhowIfIdIsNotUnique()
        {
            database.Add(new Person(1, "Gosho"));
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>
                (() => database.Add(new Person(1, "Kiril")));
            Assert.AreEqual(exception.Message, "There is already user with this Id!");
        }

        [Test]
        public void ShouldThrowWhenRemoveElementWithZeroCount()
        {
            Assert.Throws<InvalidOperationException>(() => database.Remove());
            
        }

        [Test]
        public void RemoveElements()
        {
            database = new Database(new Person(1, "Pesho"), new Person(2,"Todor"));
            database.Remove();
            Person result = database.FindById(1);

            Assert.AreEqual(1, database.Count);
            Assert.AreEqual("Pesho", result.UserName);
        }

        [Test]
        public void ShouldTrhowIfUsernameDoesNotExist()
        {
           
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>
                (() => database.FindByUsername("Kiro"));
            Assert.AreEqual(exception.Message, "No user is present by this username!");
        }

        [Test]
        public void ShouldTrhowIfUsernameIsNullOrEmpty()
        {
            
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>
                (() => database.FindByUsername(null));
            Assert.AreEqual(exception.ParamName, "Username parameter is null!");

            ArgumentNullException emptyEx = Assert.Throws<ArgumentNullException>
                (() => database.FindByUsername(string.Empty));
            Assert.AreEqual(emptyEx.ParamName, "Username parameter is null!");
        }

        [Test]
        public void TestFindByUsername()
        {
            database = new Database(new Person(1, "Pesho"), new Person(2, "Todor"));
            Person result = database.FindByUsername("Todor");

            Assert.AreEqual("Todor", result.UserName);
        }

        [Test]
        public void ShoulTrhowFindByIdWithNegativeNumber()
        {
            ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>
                (() => database.FindById(-1));
            Assert.AreEqual(exception.ParamName, "Id should be a positive number!");


        }

        [Test]
        public void ShouldTrhowIfIdDoesNotExist()
        {

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>
                (() => database.FindById(3));
            Assert.AreEqual(exception.Message, "No user is present by this ID!");
        }

        [Test]
        public void TestFiindById()
        {
            database = new Database(new Person(3, "Ivan"),new Person(8, "Marin"));
            Person result = database.FindById(3);
            Assert.AreEqual(3, result.Id);
            Assert.AreEqual("Ivan", result.UserName);
        }
        private Person[] CreateFullArray()
        {
            Person[] persons = new Person[16];

            for(int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person(i, i.ToString());
            }
            return persons;
        }
    }
}