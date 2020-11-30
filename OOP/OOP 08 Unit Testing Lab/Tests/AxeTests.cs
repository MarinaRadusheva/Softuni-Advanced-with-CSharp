using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeShouldLoseDurabilityAfterAttack()
        {
            // Arrange
            Axe axe = new Axe(15, 20);
            Dummy dummy = new Dummy(30, 30);
            // Act
            axe.Attack(dummy);
            // Assert
            int expectedResult = 19;
            int actualResult = axe.DurabilityPoints;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void AttackWithABrokenWeaponShouldThrowException()
        {
            // Arrange
            Axe axe = new Axe(10, 0);
            Dummy dummy = new Dummy(10, 20);
            // Act - Assert
            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
    }
}
