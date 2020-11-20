using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        private string model;
        private double power;
        private double displacement;
        private string efficiency;
        public Engine(string model, double power)
        {
            this.Model = model;
            this.Power = power;
        }
        public Engine(string model, double power, double displacement):this(model, power)
        {            
            this.Displacement = displacement;
        }
        public Engine(string model, double power, string efficiency) : this(model, power)
        {
            this.Efficiency = efficiency;
        }
        public Engine(string model, double power, double displacement, string efficiency):this(model, power, displacement)
        {
            this.Efficiency = efficiency;
        }
        public string Model { get; }
        public double Power { get;}
        public double Displacement { get; set; }
        public string Efficiency { get; set; }
    }
}
