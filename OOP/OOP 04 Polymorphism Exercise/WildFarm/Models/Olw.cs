using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    class Owl : Bird
    {
        private const double WeightIncrease = 0.25;
        private static List<string> AllowedFood = new List<string> {"Meat"};
        private string name;
        private double weight;
        private double wingSize;
        private int foodEaten;
        public Owl(string name, double weight, double wingSize)
        {
            this.Name = name;
            this.Weight = weight;
            this.WingSize = wingSize;
        }
        public override double WingSize { get => this.wingSize; set => this.wingSize = value; }
        public override string Name { get => this.name; set => this.name=value; }
        public override double Weight { get => this.weight; set => this.weight = value; }
        public override int FoodEaten { get => this.foodEaten; set => this.foodEaten = value; }

        public override void Eat(Food food)
        {
            if (!AllowedFood.Contains(food.GetType().Name))
            {
                throw new ArgumentException(string.Format(DOES_NOT_EAT_FOOD, this.GetType().Name, food.GetType().Name));
            }
            else
            {
                this.FoodEaten += food.Quantity;
                this.Weight += food.Quantity * WeightIncrease;
            }
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
