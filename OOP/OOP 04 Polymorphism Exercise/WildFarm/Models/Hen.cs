using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    class Hen : Bird
    {
        private const double WeightIncrease = 0.35;
        private string name;
        private double weight;
        private double wingSize;
        private int foodEaten;
        public Hen(string name, double weight, double wingSize)
        {
            this.Name = name;
            this.Weight = weight;
            this.WingSize = wingSize;
        }
        public override double WingSize { get => this.wingSize; set => this.wingSize = value; }
        public override string Name { get => this.name; set => this.name = value; }
        public override double Weight { get => this.weight; set => this.weight = value; }
        public override int FoodEaten { get => this.foodEaten; set => this.foodEaten = value; }

        public override void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * WeightIncrease;
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
