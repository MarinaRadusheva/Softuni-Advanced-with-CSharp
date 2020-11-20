using System;
using System.Collections.Generic;
using System.Text;

namespace DefinigClasses
{
    public class Car
    {
        private string model;
        private double fuel;
        private double litresPerKm;
        private double travelledDistance=0;
        public Car(string model, double fuel, double consumption)
        {
            this.Model = model;
            this.Fuel = fuel;
            this.LitresPerKm = consumption;
        }
        public string Model { get; set; }
        public double Fuel { get; set; }
        public double LitresPerKm { get; set; }
        public double TravelledDistance 
        { 
            get
            { return travelledDistance; }
        }
        public void Drive(double targetDistance)
        {
            double fuelLeft = this.Fuel -(this.LitresPerKm * targetDistance);
            if (fuelLeft>=0)
            {
                this.Fuel = fuelLeft;
                this.travelledDistance += targetDistance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        public void PrintCar()
        {
            Console.WriteLine($"{this.Model} {this.Fuel:F2} {this.TravelledDistance}");
        }
    }
}
