using NUnit.Framework;
using System;
namespace Tests
{
    public class DatabaseTests
    {
        private Database.Database database;
        private Database.Database databaseWithElements;
        [SetUp]
        public void Setup()
        {
            this.database = new Database.Database();
            this.databaseWithElements = new Database.Database(1, 2, 3, 4);
        }

        [Test]
        public void ConstructorShouldInitializeEmptyDatabase()
        {
            int expectedResult = 0;
            int actualResult = database.Count;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void CounstructorTakingMorethan16ParamsShouldThrowEx()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Database.Database excessDatabase = new Database.Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17);
            });

        }
        [Test]
        public void AddingElementsShouldChangeCount()
        {
            this.databaseWithElements.Add(5);
            int expectedResult = 5;
            int actualResult = this.databaseWithElements.Count;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void AddingElementToAFullDatabaseShouldThrowEx()
        {
            Database.Database excessDatabase = new Database.Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.Throws<InvalidOperationException>(() => excessDatabase.Add(17));
        }
        [Test]
        public void RemovingFromEmptyDatabaseShouldThrowEx()
        {
            Assert.Throws<InvalidOperationException>(() => this.database.Remove());
        }
        [Test]
        public void RemovingShouldDecreaseCountByOne()
        {
            this.databaseWithElements.Remove();
            int expectedRes = 3;
            int actualRes = this.databaseWithElements.Count;
            Assert.AreEqual(expectedRes, actualRes);
        }
        [Test]
        public void FetchShouldWorkProperly()
        {
            int[] expected = new int[] { 1, 2, 3, 4 };
            int[] actual = this.databaseWithElements.Fetch();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void FetchShouldWorkProperlyWithEmptyArray()
        {
            Assert.IsEmpty(this.database.Fetch());
        }
    }
}