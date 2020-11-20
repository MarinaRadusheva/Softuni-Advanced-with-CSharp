using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} 
        //{tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;
        public Car(string model, int engSpeed, int engPower, int cargoWeight, string cargoType, double tire1pressure, int tire1Age, double tire2pressure, int tire2Age, double tire3pressure, int tire3Age, double tire4pressure, int tire4Age)
        {
            this.Model = model;
            this.Engine = new Engine(engSpeed, engPower);
            this.Cargo = new Cargo(cargoWeight, cargoType);
            this.Tires = new Tire[]
            {
                new Tire(tire1pressure, tire1Age),
                new Tire(tire2pressure, tire2Age),
                new Tire(tire3pressure, tire3Age),
                new Tire(tire4pressure, tire4Age),

            };
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }
    }
}
