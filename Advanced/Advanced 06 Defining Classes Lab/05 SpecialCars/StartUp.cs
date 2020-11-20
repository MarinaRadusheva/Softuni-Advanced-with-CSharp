using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> allTires = GetTires();
            List<Engine> allEngines = GetEngines();
            List<Car> specialCars = GetSpecialCars(allTires, allEngines);
            foreach (var specialCar in specialCars)
            {
                specialCar.Drive(20);
                Console.WriteLine(specialCar.WhoAmI());
            }
        }


        public static List<Car> GetSpecialCars(List<Tire[]> allTires, List<Engine> allEngines)
        {
            List<Car> specialCars = new List<Car>();
            string carLine = Console.ReadLine();
            while (carLine!="Show special")
            {                
                string[] carParameters = carLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);                             
                int year = int.Parse(carParameters[2]);                              
                Engine currentEngine = allEngines[int.Parse(carParameters[5])];
                Tire[] currentTyres = allTires[int.Parse(carParameters[6])];
                double sum = currentTyres.Sum(x => x.Pressure);
                if (year>=2017&&currentEngine.HorsePower>330&&sum>=9&&sum<=10)
                {
                    string make = carParameters[0];
                    string model = carParameters[1];
                    double fuel = double.Parse(carParameters[3]);
                    double consumption = double.Parse(carParameters[4]);
                    specialCars.Add(new Car(make, model, year, fuel, consumption, currentEngine, currentTyres));
                }
                carLine = Console.ReadLine();
            }
            return specialCars;
        }

         public static List<Engine> GetEngines()
        {
            string engineLine = Console.ReadLine();
            List<Engine> allEngines = new List<Engine>();
            while (engineLine!="Engines done")
            {
                string[] engineParameters = engineLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine nextEngine = new Engine(int.Parse(engineParameters[0]), double.Parse(engineParameters[1]));
                allEngines.Add(nextEngine);
                engineLine = Console.ReadLine();
            }
            return allEngines;
        }

         public static List<Tire[]> GetTires()
        {
            List<Tire[]> carsTires = new List<Tire[]>();
            string newTires = Console.ReadLine();
            while (newTires!="No more tires")
            {
                string[] tireParameters = newTires.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                //2 2.6 3 1.6 2 3.6 3 1.6
                Tire[] next4Tires = new Tire[4];
                int tireCount = 0;
                for (int i = 0; i < tireParameters.Length; i+=2)
                {
                   Tire tire = new Tire(int.Parse(tireParameters[i]), double.Parse(tireParameters[i + 1]));
                    next4Tires[tireCount] = tire;
                    tireCount++;
                }
                carsTires.Add(next4Tires);
                newTires = Console.ReadLine();
            }
            return carsTires;
        }
    }
}
