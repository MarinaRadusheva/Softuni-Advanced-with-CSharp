using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Tire[] tires = new Tire[4]
            {
                new Tire(1, 2.25),
                new Tire(1, 1.85),
                new Tire(2, 2.15),
                new Tire(2, 2.00),
            };
            Engine engine = new Engine(230, 1.6);
            Car newCar = new Car("Mustang", "M3", 1957, 200, 15, engine, tires);
        }
    }
}
