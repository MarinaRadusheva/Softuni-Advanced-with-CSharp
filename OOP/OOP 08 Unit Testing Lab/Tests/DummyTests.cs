using System;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class DummyTests
    {
        private Axe axe = new Axe(20, 20);
        private Dummy dummy;
        [Test]
        [TestCase(50, 20)]
        public void DummyShouldLoseHealthIfAttacked(int health, int exp)
        {
            //Arrange
            dummy = new Dummy(health, exp);
            // Act
            axe.Attack(dummy);
            // Assert
            bool expectedResult = true;
            bool actualResult = dummy.Health < health;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void DeadDummyShouldThrowsExceptionIfAttacked()
        {
            // Arrange
            dummy = new Dummy(0, 20);
            //Act-Assert
            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
        [Test]
        [TestCase(0, 20)]
        public void DeadDummyShouldGiveXP(int health, int experience)
        {
            // Arrange
            dummy = new Dummy(0, 20);
            // Act
            int exp = dummy.GiveExperience();
            // Assert
            Assert.That(exp.Equals(experience));
        }
        [Test]
        public void AliveDummyShouldNotBeAbletoGiveXP()
        {
            //Arrange
            dummy = new Dummy(20, 20);
            //Act-Assert
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }


    }
}
