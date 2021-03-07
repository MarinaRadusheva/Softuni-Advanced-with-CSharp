

using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class ArenaTests
    {
        private Warrior Warrior1;
        private Warrior StrongerWarrior;
        private Warrior WeakerWarrior;
        [SetUp]
        public void Setup()
        {
            Warrior1 = new Warrior("Shoshko", 40, 40);
            WeakerWarrior = new Warrior("Pussy", 10, 10);
            StrongerWarrior = new Warrior("BadAss", 50, 50);
        }

        [Test]
        public void ConstructorShouldInitializeEmptyList()
        {
            Arena arena = new Arena();
            int expListCount = 0;
            int actualListCount = arena.Warriors.Count;
            Assert.AreEqual(expListCount, actualListCount);
        }
        [Test]
        public void CountShouldBeZeroUponInitialization()
        {
            Arena arena = new Arena();
            int expCount = 0;
            int actualListCount = arena.Count;
            Assert.AreEqual(expCount, actualListCount);
        }

        [Test]
        public void CountShouldIncreaseWhenAddingWarriors()
        {
            Arena arena = new Arena();
            arena.Enroll(Warrior1);
            arena.Enroll(StrongerWarrior);
            arena.Enroll(WeakerWarrior);
            int expCount = 3;
            int actualListCount = arena.Count;
            Assert.AreEqual(expCount, actualListCount);
        }
        [Test]
        public void WarriorsCountShouldIncreaseWhenAddingWarriors()
        {
            Arena arena = new Arena();
            arena.Enroll(Warrior1);
            arena.Enroll(StrongerWarrior);
            arena.Enroll(WeakerWarrior);
            int expCount = 3;
            int actualListCount = arena.Warriors.Count;
            Assert.AreEqual(expCount, actualListCount);
        }
        [Test]
        public void EnrollingExistingWarriorShouldThrowException()
        {
            Arena arena = new Arena();
            arena.Enroll(Warrior1);
            arena.Enroll(StrongerWarrior);
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(Warrior1), "Warrior is already enrolled for the fights!");
        }
        [Test]
        public void FightingWithAMissingAttackerShouldThrowEx()
        {
            Arena arena = new Arena();
            arena.Enroll(Warrior1);
            arena.Enroll(StrongerWarrior);
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Dinko", "BadAss"), "There is no fighter with name Dinko enrolled for the fights!");
        }
        [Test]
        public void FightingWithAMissingDefenderShouldThrowEx()
        {
            Arena arena = new Arena();
            arena.Enroll(Warrior1);
            arena.Enroll(StrongerWarrior);
            Assert.Throws<InvalidOperationException>(() => arena.Fight("BadAss", "Dinko"), "There is no fighter with name Dinko enrolled for the fights!");
        }

        [Test]
        public void FightingWithBothMissingFightersShouldThrowEx()
        {
            Arena arena = new Arena();
            arena.Enroll(Warrior1);
            arena.Enroll(StrongerWarrior);
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Chocho", "Dinko"));
        }
        [Test]
        public void AttackShouldWorkProperly()
        {
            Arena arena = new Arena();
            Warrior Warrior2 = new Warrior("Shoshko", 40, 60);
            arena.Enroll(Warrior2);
            arena.Enroll(StrongerWarrior);
            arena.Fight("BadAss", "Shoshko");
            int expectedHP = 10;
            int actualHP = Warrior2.HP;
            Assert.AreEqual(expectedHP, actualHP);
            Assert.AreEqual(10, StrongerWarrior.HP);
        }
    }
}