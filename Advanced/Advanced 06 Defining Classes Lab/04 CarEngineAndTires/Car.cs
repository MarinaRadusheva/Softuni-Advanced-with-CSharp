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

        public Car() : this("VW", "Golf", 2025, 200, 10)
        { }
        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make, string model, int year, double quantity, double consumption):this(make, model, year)
        {
            this.FuelQuantity = quantity;
            this.FuelConsumption = consumption;
        }
        public Car(string make, string model, int year, double quantity, double consumption, Engine engine, Tire[] tires)
            :this(make, model, year, quantity, consumption)
        {
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
            if (this.fuelQuantity-(this.FuelConsumption*distance)>=0)
            {
                this.fuelQuantity -= this.FuelConsumption * distance;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L";
        }

    }
}
