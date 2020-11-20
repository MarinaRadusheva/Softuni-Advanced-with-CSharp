using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Common;
namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double ConsumptionWithAC = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, (fuelConsumption+ConsumptionWithAC), tankCapacity)
        {

        }
        public override void Refuel(double litres)
        {
            if (ValidateFuelAmount(litres))
            {
                double newFuelQuantity = this.FuelQuantity + litres * 0.95;
                if (newFuelQuantity > this.TankCapacity)
                {
                    throw new ArgumentException(string.Format(Constants.TOO_MUCH_FUEL, litres));
                }
                this.FuelQuantity = newFuelQuantity;
            }
            
        }
    }
}
