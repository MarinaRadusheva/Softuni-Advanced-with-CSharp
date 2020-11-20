using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public  class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

      
        public Car(string make, string model, int year, double quantity, double consumption, Engine engine, Tire[] tires)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.FuelQuantity = quantity;
            this.FuelConsumption = consumption;
            this.Engine = engine;
            this.Tires = tires;
        }
        public string Make { get; set; }
        public string  Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public  Tire[] Tires { get; set; }
        public void Drive(double distance)
        {
            double fuelNeeded = (this.FuelConsumption * distance) / 100;
            if (this.FuelQuantity-fuelNeeded>=0)
            {
                this.FuelQuantity -= fuelNeeded;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Year: {this.Year}");
            sb.AppendLine($"HorsePowers: {this.Engine.HorsePower}");
            sb.AppendLine($"FuelQuantity: {this.FuelQuantity}");

            return sb.ToString();

        }
    }
}
