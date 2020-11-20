using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Common;
namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double ConsumptionIncrease = 1.4;
        private double fuelConsumptionEmpty;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption+ConsumptionIncrease, tankCapacity)
        {
            this.fuelConsumptionEmpty = fuelConsumption;
        }
       public void DriveEmpty(double km)
        {
            double neededFuel = this.fuelConsumptionEmpty * km;
            if (neededFuel > this.FuelQuantity)
            {
                throw new ArgumentException(string.Format(Constants.NOT_ENOUGH_FUEL_MSG, this.GetType().Name));
            }
            this.FuelQuantity -= neededFuel;
            //to do: travelled message
        }
    }
}
