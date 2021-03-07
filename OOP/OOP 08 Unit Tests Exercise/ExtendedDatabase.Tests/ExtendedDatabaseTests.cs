using ExtendedDatabase;
using NUnit.Framework;
using System;

namespace ExtendedDatabaseTests
{
    [TestFixture]
    public class Tests
    {
        private Person[] people;
        private ExtendedDatabase.ExtendedDatabase database;
        private ExtendedDatabase.ExtendedDatabase emptyDatabase;
        private ExtendedDatabase.ExtendedDatabase fullDatabase;
        [SetUp]
        public void Setup()
        {
            this.emptyDatabase = new ExtendedDatabase.ExtendedDatabase();
            this.people = new Person[16];
            for (long i = 0; i < 16; i++)
            {
                Person person = new Person(i, "Pesho" + i);
                people[i] = person;
            }
            this.fullDatabase = new ExtendedDatabase.ExtendedDatabase(people);
            this.database = null;

        }
        [Test]
        public void PersonConstructorShouldWorkCorrectly()
        {
            Person newPerson = new Person(31, "Gosho");
            Assert.AreEqual("Gosho", newPerson.UserName);
            Assert.AreEqual(31, newPerson.Id);
        }

        [Test]
        public void ConstructorShouldInitializeEmptyPeopleArray()
        {
            Assert.AreEqual(0, this.emptyDatabase.Count);
        }
        [Test]
        public void ConstructorShouldInitializeArrayCorrectly()
        {
            Assert.AreEqual(16, this.fullDatabase.Count);
        }
        [Test]
        public void ConstructorShouldThrowExIfPeopleMoreThan16()
        {
            Person[] tooManyPeople = new Person[17];
            for (long i = 0; i < 17; i++)
            {
                Person person = new Person(i, "Misho" + i);
                tooManyPeople[i] = person;
            }
            Assert.Throws<ArgumentException>(() => this.database = new ExtendedDatabase.ExtendedDatabase(tooManyPeople));
        }
        [Test]
        public void ConstructorShouldThrowExIfThereAreSameNames()
        {
            Person person = new Person(17, "Gary");
            Person person2 = new Person(18, "Gary");
            Assert.Throws<InvalidOperationException>(() => database = new ExtendedDatabase.ExtendedDatabase(person, person2));
        }
        [Test]
        public void ConstructorShouldThrowExIfThereAreSameIDs()
        {
            Person person = new Person(17, "Gary");
            Person person2 = new Person(17, "Lary");
            Assert.Throws<InvalidOperationException>(() => database = new ExtendedDatabase.ExtendedDatabase(person, person2));
        }

        [Test]
        public void Adding17thPersonShouldThrowEx()
        {
            Person person = new Person(17, "Gary");
            Assert.Throws<InvalidOperationException>(() => this.fullDatabase.Add(person));
        }
        [Test]
        public void AddingExistingPersonNameShouldThrowEx()
        {
            Person person = new Person(17, "Gary");
            Person person2 = new Person(18, "Gary");
            this.emptyDatabase.Add(person);
            Assert.Throws<InvalidOperationException>(() => emptyDatabase.Add(person2));
        }
        [Test]
        public void AddingExistingPersonIDShouldThrowEx()
        {
            Person person = new Person(17, "Gary");
            Person person2 = new Person(17, "Lary");
            this.emptyDatabase.Add(person);
            Assert.Throws<InvalidOperationException>(() => emptyDatabase.Add(person2));
        }
        [Test]
        public void AddingPersonShouldWorkProperly()
        {
            Person person = new Person(17, "Gary");
            this.emptyDatabase.Add(person);
            Person person2 = new Person(18, "Lary");
            this.emptyDatabase.Add(person2);
            Assert.AreEqual(2, this.emptyDatabase.Count);
        }
        [Test]
        public void RemovingFromEmptyDatabaseShouldThrowEx()
        {
            Assert.Throws<InvalidOperationException>(() => this.emptyDatabase.Remove());
        }
        [Test]
        public void RemovingWorksProperly()
        {
            this.fullDatabase.Remove();
            Assert.AreEqual(15, this.fullDatabase.Count);
        }
        [Test]
        public void FindByNullNameShouldThrowEx()
        {
            string name = "";
            Assert.Throws<ArgumentNullException>(() => this.fullDatabase.FindByUsername(name));
        }
        [Test]
        public void FindByEmptyNameShouldThrowEx()
        {
            string name = null;
            Assert.Throws<ArgumentNullException>(() => this.fullDatabase.FindByUsername(name));
        }

        [Test]
        public void FindByNonExistingNameShouldThrowEx()
        {
            Assert.Throws<InvalidOperationException>(() => this.fullDatabase.FindByUsername("MArina"));
        }
        [Test]
        public void FindByNameShouldWorkProperly()
        {
            string expectedName = "Pesho1";
            Person actualPerson = fullDatabase.FindByUsername("Pesho1");
            Assert.AreEqual(expectedName, actualPerson.UserName);
        }
        [Test]
        public void FindByIDShouldThrowExIfNumpberNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => fullDatabase.FindById(-1L));
        }
        [Test]
        public void FindByIDShouldThrowExIfNoSuchID()
        {
            Assert.Throws<InvalidOperationException>(() => fullDatabase.FindById(20L));
        }
        [Test]
        public void FindByIDShouldWorkProperly()
        {
            long expectedResult = 1;
            Person person = fullDatabase.FindById(1L);
            long actualResult = person.Id;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}