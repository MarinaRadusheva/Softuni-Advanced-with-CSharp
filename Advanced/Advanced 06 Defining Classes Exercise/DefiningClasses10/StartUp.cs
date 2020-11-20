using System;

namespace SoftUniParking
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car("Mazda", "323f", 120, "m8743");
            Console.WriteLine(car);
        }
    }
}
