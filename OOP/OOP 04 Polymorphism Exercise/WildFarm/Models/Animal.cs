using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public abstract class Animal
    {
        public const string DOES_NOT_EAT_FOOD = "{0} does not eat {1}!";
        public abstract string Name { get; set; }
        public abstract double Weight { get; set; }
        public abstract int FoodEaten { get; set; }
        public abstract string ProduceSound();
        public abstract override string ToString();

        public abstract void Eat(Food food);
    }
}
