﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Dog : Mammal
    {
        private const double WeightIncrease = 0.4;
        private static List<string> AllowedFood = new List<string>{"Meat" };
        private string name;
        private double weight;
        private int foodEaten;
        private string livingRegion;
        public Dog(string name, double weight, string region)
        {
            this.Name = name;
            this.Weight = weight;
            this.LivingRegion = region;
        }
        public override string LivingRegion { get => this.livingRegion; set => this.livingRegion = value; }
        public override string Name { get => this.name; set => this.name = value; }
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
            return "Woof!";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
