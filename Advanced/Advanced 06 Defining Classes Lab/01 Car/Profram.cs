using CarManufacturer;
using System;
using System.IO.Compression;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Mazda";
            car.Model = "323 f";
            car.Year = 1995;
            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
            
        }
    }
}
