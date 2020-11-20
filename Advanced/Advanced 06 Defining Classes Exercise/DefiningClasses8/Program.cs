using DefiningClasses;
using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            int enginesCount = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> allEngines = new Dictionary<string, Engine>();
            for (int i = 0; i < enginesCount; i++)
            {
                //{model} {power} {displacement} {efficiency}"
                string[] engineTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine newEngine = GetEngine(engineTokens);
                if (!allEngines.ContainsKey(newEngine.Model))
                {
                    allEngines.Add(newEngine.Model, newEngine);
                }
            }
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> allCars = new List<Car>();
            for (int i = 0; i < carsCount; i++)
            {
                //model} {engine} {weight} {color}
                string[] carTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                allCars.Add(GetCar(allEngines, carTokens));
            }
            foreach (var car in allCars)
            {
                car.PrintCar();
            }

        }

        public static Car GetCar(Dictionary<string, Engine> allEngines, string[] carTokens)
        {
            string carModel = carTokens[0];
            Engine carEngine = allEngines[carTokens[1]];
            Car newCar;
            if (carTokens.Length == 3)
            {
                double number;
                if (Double.TryParse(carTokens[2], out number))
                {
                    double carWeight = double.Parse(carTokens[2]);
                    newCar = new Car(carModel, carEngine, carWeight);
                }
                else
                {
                    string carColor = carTokens[2];
                    newCar = new Car(carModel, carEngine, carColor);
                }
            }
            else if (carTokens.Length == 4)
            {
                double carWeight = double.Parse(carTokens[2]);
                string carColor = carTokens[3];
                newCar = new Car(carModel, carEngine, carWeight, carColor);
            }
            else
            {
                newCar = new Car(carModel, carEngine);
            }
            return newCar;
        }

        public static Engine GetEngine(string[] engineTokens)
        {
            Engine newEngine;
            string engineModel = engineTokens[0];
            double enginePower = double.Parse(engineTokens[1]);
            if (engineTokens.Length == 3)
            {
                double number;
                if (Double.TryParse(engineTokens[2], out number))
                {
                    double engineDisplacement = double.Parse(engineTokens[2]);
                    newEngine = new Engine(engineModel, enginePower, engineDisplacement);
                }
                else
                {
                    string engineEfficiency = engineTokens[2];
                    newEngine = new Engine(engineModel, enginePower, engineEfficiency);
                }
            }
            else if (engineTokens.Length == 4)
            {
                double engineDisplacement = double.Parse(engineTokens[2]);
                string engineEfficiency = engineTokens[3];
                newEngine = new Engine(engineModel, enginePower, engineDisplacement, engineEfficiency);
            }
            else
            {
                newEngine = new Engine(engineModel, enginePower);
            }
            return newEngine;
        }
    }
}
