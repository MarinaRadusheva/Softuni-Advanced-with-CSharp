using System;
using System.Collections.Generic;

namespace DefinigClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            for (int i = 0; i < n; i++)
            {
                string[] carLine = Console.ReadLine().Split();
                string model = carLine[0];
                double fuel = double.Parse(carLine[1]);
                double ltrPerKm = double.Parse(carLine[2]);
                Car newCar = new Car(model, fuel, ltrPerKm);
                if (!cars.ContainsKey(model))
                {
                    cars.Add(model, newCar);
                }
            }
            string driveCommand = "";
            while ((driveCommand=Console.ReadLine())!="End")
            {
                string[] carTokens = driveCommand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carDriving = carTokens[1];
                double drivingDistance = double.Parse(carTokens[2]);
                cars[carDriving].Drive(drivingDistance);
            }
            foreach (var item in cars)
            {
                item.Value.PrintCar();
            }
        }
    }
}
