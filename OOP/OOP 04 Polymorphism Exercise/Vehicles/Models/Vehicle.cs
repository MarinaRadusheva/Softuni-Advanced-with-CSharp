using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Common;
namespace Vehicles
{
    public class Vehicle
    {
       
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;
        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;

        }
        public double FuelQuantity
        {
            get => this.fuelQuantity;
            set
            { 
                if (this.TankCapacity < value)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }               
            }
        }
        public double FuelConsumption
        {
            get => this.fuelConsumption;
            private set
            {
                this.fuelConsumption = value;
            }
        }
        public double TankCapacity 
        {
            get => this.tankCapacity;
            private set
            {
                this.tankCapacity = value;
            }
        }

        public void Drive(double km)
        {
            double neededFuel = this.FuelConsumption * km;
            if (neededFuel>this.FuelQuantity)
            {
                throw new ArgumentException(string.Format(Constants.NOT_ENOUGH_FUEL_MSG, this.GetType().Name));
            }
            this.FuelQuantity -= neededFuel;
            //to do: travelled message
        }
        public virtual void Refuel(double litres)
        {
            if (ValidateFuelAmount(litres))
            {
                double newFuelQuantity = this.FuelQuantity + litres;
                if (newFuelQuantity>this.TankCapacity)
                {
                    throw new ArgumentException(string.Format(Constants.TOO_MUCH_FUEL, litres));
                }
                this.FuelQuantity = newFuelQuantity;
            }
        }
        protected bool ValidateFuelAmount(double litres)
        {
            if (litres<=0)
            {
                throw new ArgumentException(Constants.NEGATIVE_LITRES_EXC);
            }
            return true;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
