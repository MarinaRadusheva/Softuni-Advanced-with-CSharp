using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine engine;
        private double weight;
        private string colour;
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }
        public Car(string model, Engine engine, double weight):this(model, engine)
        {
            this.Weight = weight;
        }
        public Car(string model, Engine engine, string colour):this(model, engine)
        {
            this.Colour = colour;
        }
        public Car(string model, Engine engine, double weight, string colour):this(model, engine, weight)
        {
            this.Colour = colour;
        }
        public string Model { get; }
        public Engine Engine { get; }
        public double Weight { get;}
        public string Colour { get; set; }

        public void PrintCar()
        {
            Console.WriteLine($"{ this.Model}:");
            Console.WriteLine($"  { this.Engine.Model}:");
            Console.WriteLine($"    Power: {this.Engine.Power}");
            if (this.Engine.Displacement!=0)
            {
                Console.WriteLine($"    Displacement: {this.Engine.Displacement}");
            }
            else
            {
                Console.WriteLine("    Displacement: n/a");
            }
            if (this.Engine.Efficiency!=null)
            {
                Console.WriteLine($"    Efficiency: {this.Engine.Efficiency}");
            }
            else
            {
                Console.WriteLine("    Efficiency: n/a");
            }
            if (this.Weight!=0)
            {
                Console.WriteLine($"  Weight: {this.Weight}");
            }
            else
            {
                Console.WriteLine("  Weight: n/a");
            }
            if (this.Colour!=null)
            {
                Console.WriteLine($"  Color: {this.Colour}");
            }
            else
            {
                Console.WriteLine("  Color: n/a");
            }
                 
        }
    }
}
