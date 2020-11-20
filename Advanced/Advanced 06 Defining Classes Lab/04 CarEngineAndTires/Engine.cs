using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;
        public Engine(int horsePower, double capacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = capacity;
        }
        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }
    }
}
