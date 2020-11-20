using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Models;
using Vehicles.Common;
namespace Vehicles.Core
{
    public class Engine
    {
        private Vehicle car;
        private Vehicle truck;
        private Vehicle bus;
        public Engine()
        { }
        public void Run()
        {

            CreateVehicles();
            int commandsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandsCount; i++)
            {
                string[] commandTokens = Console.ReadLine().Split();
                ExecuteCommand(commandTokens);
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private void ExecuteCommand(string[] commandTokens)
        {
            string command = commandTokens[0];
            if (command == "Drive")
            {
                double km = double.Parse(commandTokens[2]);
                string vehicleType = commandTokens[1];
                try
                {
                    switch (vehicleType)
                    {
                        case "Car":
                            car.Drive(km);
                            break;
                        case "Truck":
                            truck.Drive(km);
                            break;
                        case "Bus":
                            bus.Drive(km);
                            break;
                    }
                    Console.WriteLine(string.Format(Constants.VEHICLE_TRAVELLED_KM, vehicleType, km));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            else if (command == "Refuel")
            {
                string vehicleType = commandTokens[1];
                double litres = double.Parse(commandTokens[2]);
                try
                {

                    switch (vehicleType)
                    {
                        case "Car":
                            car.Refuel(litres);
                            break;
                        case "Truck":
                            truck.Refuel(litres);
                            break;
                        case "Bus":
                            bus.Refuel(litres);
                            break;
                    }

                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            else if (command == "DriveEmpty")
            {
                double km = double.Parse(commandTokens[2]);
                try
                {
                    (bus as Bus).DriveEmpty(km);
                    Console.WriteLine(string.Format(Constants.VEHICLE_TRAVELLED_KM, bus.GetType().Name, km));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        private void CreateVehicles()
        {
            for (int i = 0; i < 3; i++)
            {
                string[] vehicleInfo = Console.ReadLine().Split();
                string vehicleType = vehicleInfo[0];
                double fuelQuantity = double.Parse(vehicleInfo[1]);
                double fuelConsumption = double.Parse(vehicleInfo[2]);
                double tankCapacity = double.Parse(vehicleInfo[3]);
                if (vehicleType == "Car")
                {
                    car = new Car(fuelQuantity, fuelConsumption, tankCapacity);
                }
                else if (vehicleType == "Truck")
                {
                    truck = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
                }
                else if (vehicleType == "Bus")
                {
                    bus = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
                }
            }

        }
    }
}

//for (int i = 0; i< 3; i++)
//            {
//                string[] vehicleInfo = Console.ReadLine().Split();
//                try
//                {
//                    switch (vehicleInfo[0])
//                    {
//                        case "Car":
//                            car = new Car(double.Parse(vehicleInfo[1]), double.Parse(vehicleInfo[2]), double.Parse(vehicleInfo[3]));
//                            break;
//                        case "Truck":
//                            truck = new Truck(double.Parse(vehicleInfo[1]), double.Parse(vehicleInfo[2]), double.Parse(vehicleInfo[3]));
//                            break;
//                        case "Bus":
//                            bus = new Bus(double.Parse(vehicleInfo[1]), double.Parse(vehicleInfo[2]), double.Parse(vehicleInfo[3]));
//                            break;
//                    }
//                }
//                catch (Exception ex)
//                {

//                    Console.WriteLine(ex.Message);
//                }
//            }
//            int commandsCount = int.Parse(Console.ReadLine());
//            for (int i = 0; i<commandsCount; i++)
//            {
//                string[] command = Console.ReadLine().Split();
//ExecuteCommand(command);
//            }
//            Console.WriteLine(car);
//            Console.WriteLine(truck);
//            Console.WriteLine(bus);
//        }

//        private void ExecuteCommand(string[] tokens)
//{
//    try
//    {
//        if (tokens[0] == "Drive")
//        {
//            double km = double.Parse(tokens[2]);
//            string vehicle = tokens[1];
//            if (vehicle == "Car")
//            {
//                Console.WriteLine(this.car.Drive(km));
//            }
//            else if (vehicle == "Truck")
//            {
//                Console.WriteLine(this.truck.Drive(km));
//            }
//            else
//            {
//                Console.WriteLine(this.bus.Drive(km));
//            }
//        }
//        else if (tokens[0] == "Refuel")
//        {
//            try
//            {
//                double litres = double.Parse(tokens[2]);
//                string vehicle = tokens[1];
//                if (vehicle == "Car")
//                {
//                    this.car.Refuel(litres);
//                }
//                else if (vehicle == "Truck")
//                {
//                    this.truck.Refuel(litres);
//                }
//                else
//                {
//                    this.bus.Refuel(litres);
//                }
//            }
//            catch (ArgumentException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }
//        else if (tokens[0] == "DriveEmpty")
//        {
//            Console.WriteLine((this.bus as Bus).DriveEmpty(double.Parse(tokens[2])));
//        }
//    }
//    catch (ArgumentException argex)
//    {
//        Console.WriteLine(argex.Message);
//    }