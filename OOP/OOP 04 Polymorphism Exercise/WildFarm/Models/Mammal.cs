using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public abstract class Mammal : Animal
    {
        public abstract string LivingRegion { get; set; }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
