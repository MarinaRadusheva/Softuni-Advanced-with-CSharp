

using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class WarriorTests
    {
        private Warrior Warrior1;
        private Warrior StrongerWarrior;
        private Warrior WeakerWarrior;
        [SetUp]
        public void Setup()
        {
            this.StrongerWarrior = new Warrior("BadAss", 50, 50);
            this.WeakerWarrior = new Warrior("Pussy", 10, 10);
        }

        [Test]
        [TestCase(null)]
        public void ConstructorShouldthrowExIfNameNull(string name)
        {
            Assert.Throws<ArgumentException>(() => Warrior1 = new Warrior(name, 20, 20), "Name should not be empty or whitespace!");
        }
        [Test]
        [TestCase("")]
        public void ConstructorShouldthrowExIfNamerEmpty(string name)
        {
            Assert.Throws<ArgumentException>(() => Warrior1 = new Warrior(name, 20, 20), "Name should not be empty or whitespace!");
        }
        [Test]
        [TestCase(" ")]
        public void ConstructorShouldthrowExIfNameNullWhitespace(string name)
        {
            Assert.Throws<ArgumentException>(() => Warrior1 = new Warrior(name, 20, 20), "Name should not be empty or whitespace!");
        }
        [Test]
        [TestCase(0)]
        public void ConstructorShouldthrowExIfDamageZero(int damage)
        {
            Assert.Throws<ArgumentException>(() => Warrior1 = new Warrior("Gary", damage, 20), "Damage value should be positive!");
        }
        [Test]
        [TestCase(-7)]
        public void ConstructorShouldthrowExIfDamageLessThanZero(int damage)
        {
            Assert.Throws<ArgumentException>(() => Warrior1 = new Warrior("Gary", damage, 20), "Damage value should be positive!");
        }
        [Test]
        public void ConstructorShouldthrowExIfHPLessThanZero()
        {
            Assert.Throws<ArgumentException>(() => Warrior1 = new Warrior("Gary", 20, -20), "HP should not be negative!");
        }
        [Test]
        public void ConstructorShouldWorkProperly()
        {
            Warrior1 = new Warrior("Gary", 20, 30);
            Assert.AreEqual("Gary", Warrior1.Name);
            Assert.AreEqual(20, Warrior1.Damage);
            Assert.AreEqual(30, Warrior1.HP);
        }
        [Test]
        public void AttackWhenLessThanMinHPShouldThrowEx()
        {
            Warrior1 = new Warrior("Shoshko", 90, 20);
            Warrior Warrior2 = new Warrior("Goshko", 10, 40);
            Assert.Throws<InvalidOperationException>(() => Warrior1.Attack(Warrior2), "Your HP is too low in order to attack other warriors!");
        }
        [Test]
        public void AttackWhenEqualToMinHPShouldThrowEx()
        {
            Warrior1 = new Warrior("Shoshko", 90, 30);
            Warrior Warrior2 = new Warrior("Goshko", 10, 40);
            Assert.Throws<InvalidOperationException>(() => Warrior1.Attack(Warrior2), "Your HP is too low in order to attack other warriors!");
        }
        [Test]
        public void AttackingWarriorWithHPLessThanMinShouldThrowEx()
        {
            
            Assert.Throws<InvalidOperationException>(() => StrongerWarrior.Attack(WeakerWarrior), "Enemy HP must be greater than 30 in order to attack him!");
        }
        [Test]
        public void AttackingWarriorWithHPEqualToMinShouldThrowEx()
        {
            Warrior1 = new Warrior("Shoshko", 30, 30);
            Assert.Throws<InvalidOperationException>(() => StrongerWarrior.Attack(Warrior1), "Enemy HP must be greater than 30 in order to attack him!");
        }
        [Test]
        public void AttackingStrongerEnemyShouldThrowEx()
        {
            Warrior1 = new Warrior("Shoshko", 60, 40);
            Assert.Throws<InvalidOperationException>(()=>Warrior1.Attack(StrongerWarrior), "You are trying to attack too strong enemy");
        }
        [Test]
        public void AttackShouldSetHPToZeroIfAttackerDamageMoreThanVictimHP()
        {
            Warrior1 = new Warrior("Shoshko", 40, 40);
            StrongerWarrior.Attack(Warrior1);
            int expectedHP = 0;
            int actualHP = Warrior1.HP;
            Assert.AreEqual(expectedHP, actualHP);
            Assert.AreEqual(10, StrongerWarrior.HP);
        }
        [Test]
        public void AttackShouldreduceHPOfBothFighters()
        {
            Warrior1 = new Warrior("Shoshko", 40, 60);
            StrongerWarrior.Attack(Warrior1);
            int expectedHP = 10;
            int actualHP = Warrior1.HP;
            Assert.AreEqual(expectedHP, actualHP);
            Assert.AreEqual(10, StrongerWarrior.HP);
        }
    }
}
