using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RaceMotorcycle racer = new RaceMotorcycle(250, 80);
            racer.Drive(10);
            Console.WriteLine(racer.Fuel);
            Vehicle trial = new SportCar(160, 120);
            Console.WriteLine(trial.GetType());
            Car car = new Car(120, 200);
            Console.WriteLine(car.FuelConsumption);
        }
    }
}
