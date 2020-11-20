using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} 
            //{tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] carProperties = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                cars.Add(new Car(carProperties[0], int.Parse(carProperties[1]), int.Parse(carProperties[2]), int.Parse(carProperties[3]), carProperties[4], double.Parse(carProperties[5]), int.Parse(carProperties[6]), double.Parse(carProperties[7]), int.Parse(carProperties[8]), double.Parse(carProperties[9]), int.Parse(carProperties[10]), double.Parse(carProperties[11]), int.Parse(carProperties[12])));
            }
            string command = Console.ReadLine();
            if (command=="fragile")
            {
                cars = cars.Where(x => x.Cargo.Type == "fragile").Where(x =>
                      {
                          bool isLess = false;
                          foreach (var tire in x.Tires)
                          {
                              if (tire.Pressure < 1)
                              {
                                  isLess = true;
                                  break;
                              }
                          }
                          return isLess;
                      }
                      ).ToList();
            }
            else if(command=="flamable")
            {
                cars = cars.Where(x => x.Cargo.Type == "flamable").Where(x => x.Engine.EnginePower > 250).ToList();
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
