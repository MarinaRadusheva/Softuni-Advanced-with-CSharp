
using NUnit.Framework;
using System;

namespace CarTests
{
    [TestFixture]
    public class CarTests
    {
        private Car car;
        [SetUp]
        public void Setup()
        {
            car = null;
        }


        [Test]
        public void EmptyConstructorShouldSetFuelToZero()
        {
            car = new Car("Mazda", "323f", 7.5, 80);
            Assert.AreEqual(0, car.FuelAmount);
        }
        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void ConstructorShouldThrowExIfMakeEmpty(string make)
        {
            Assert.Throws<ArgumentException>(()=>car = new Car(make, "323f", 7.5, 80),"Make cannot be null or empty!");
        }
        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void ConstructorShouldThrowExIfModelEmpty(string model)
        {
            Assert.Throws<ArgumentException>(() => car = new Car("Mazda", model, 7.5, 80), "Model cannot be null or empty!");
        }
        [Test]
        [TestCase(0)]
        [TestCase(-2.3)]
        public void ConstructorShouldThrowExIfFuelConsumptionZeroOrLess(double consumption)
        {
            Assert.Throws<ArgumentException>(() => car = new Car("Mazda", "323f", consumption, 80), "Fuel consumption cannot be zero or negative!");
        }
        [Test]
        [TestCase(0)]
        [TestCase(-2.3)]
        public void ConstructorShouldThrowExIfFuelCapacityZeroOrLess(double capacity)
        {
            Assert.Throws<ArgumentException>(() => car = new Car("Mazda", "323f", 7.5, capacity), "Fuel capacity cannot be zero or negative!");
        }
        [Test]
        public void ConstructorShouldWorkProperly()
        {
            car = new Car("Mazda", "323f", 7.5, 80);
            Assert.AreEqual("Mazda", car.Make);
            Assert.AreEqual("323f", car.Model);
            Assert.AreEqual(7.5, car.FuelConsumption);
            Assert.AreEqual(80, car.FuelCapacity);
            Assert.AreEqual(0, car.FuelAmount);
        }
        [Test]
        [TestCase(0)]
        [TestCase(-2.3)]
        public void RefuelWithZeroOrLessShouldThrowEx(double fuelAmount)
        {
            car = new Car("Mazda", "323f", 7.5, 80);
            Assert.Throws<ArgumentException>(() => car.Refuel(fuelAmount), "Fuel amount cannot be zero or negative!");
        }
        [Test]
        public void RefuelWithLessThanCapacityShouldWorkCorrectlyWhenEmptyTank()
        {
            car = new Car("Mazda", "323f", 7.5, 80);
            car.Refuel(70.5);
            double expectedResult = 70.5;
            double actualResult = car.FuelAmount;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void RefuelWithMoreThanCapacityShouldWorkCorrectlyWhenEmptyTank()
        {
            car = new Car("Mazda", "323f", 7.5, 80);
            car.Refuel(90.5);
            double expectedResult = 80;
            double actualResult = car.FuelAmount;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void RefuelWithLessThanCapacityShouldWorkCorrectlyWhenTankNotEmpty()
        {
            car = new Car("Mazda", "323f", 7.5, 80);
            car.Refuel(20);
            car.Refuel(14.80);
            double expectedResult = 34.80;
            double actualResult = car.FuelAmount;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void RefuelWithMoreThanCapacityShouldWorkCorrectlyWhenTankNotEmpty()
        {
            car = new Car("Mazda", "323f", 7.5, 80);
            car.Refuel(20);
            car.Refuel(95.80);
            double expectedResult = 80;
            double actualResult = car.FuelAmount;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void DrivingShouldThrowExIfNotEnoughFuel()
        {
            car = new Car("Mazda", "323f", 7.5, 80);
            Assert.Throws<InvalidOperationException>(() => car.Drive(20), "You don't have enough fuel to drive!");
        }
        [Test]
        public void DriveShouldWorkCorrectlyIfFuelNeededEqualsFuelAvailability()
        {
            car = new Car("Mazda", "323f", 7.5, 80);
            car.Refuel(75);
            car.Drive(1000);
            Assert.AreEqual(0.00, car.FuelAmount);
        }
        [Test]
        public void DrivingShouldWorkCorrectly()
        {
            car = new Car("Mazda", "323f", 7.5, 80);
            car.Refuel(75);
            car.Drive(20);
            Assert.AreEqual(73.5, car.FuelAmount);
        }
    }
}