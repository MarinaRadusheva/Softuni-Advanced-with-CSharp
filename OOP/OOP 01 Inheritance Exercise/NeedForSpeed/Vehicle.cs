using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public int HorsePower
        {
            get; set;
        }

        public virtual double FuelConsumption
        {
            get=>this.DefaultFuelConsumption;
        }

        protected double DefaultFuelConsumption
        {
            get
            {
                return 1.25;
            }
            set
            {
            }
        }

        public double Fuel
        {
            get; set;
        }

        public virtual void Drive(double km)
        {
            this.Fuel = this.Fuel - (this.FuelConsumption * km);
        }
    }
}