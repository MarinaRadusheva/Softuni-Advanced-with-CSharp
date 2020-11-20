using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Topping
    {
        private string typeOfTopping;
        private double weight;
        private double toppingModifier;
        public Topping(string type, double grams)
        {
            this.TypeOfTopping = type;           
            this.Weight = grams;
        }
        protected string TypeOfTopping 
        {
            get => this.typeOfTopping;
            set
            {
                List<string> allowedToppings = new List<string> { "meat", "veggies", "cheese", "sauce" };
                if (!allowedToppings.Contains(value.ToLower()))
                {
                    var valuename = value[0].ToString().ToUpper() + value.Substring(1);
                    throw new ArgumentException($"Cannot place {valuename} on top of your pizza.");
                }
                this.typeOfTopping = value;
            }
        }
        protected double Weight 
        {
            get => this.weight; 
            private set
            {
                if (value<1||value>50)
                {
                    var valueName = this.TypeOfTopping[0].ToString().ToUpper() + this.TypeOfTopping.Substring(1);
                    throw new ArgumentException($"{valueName} weight should be in the range [1..50].");
                }
                this.weight = value;
            }
        }
        public double ToppingCalories { get => this.GetToppingCalories(); }
        private double GetToppingCalories()
        {
            SetModifier();
            double calories = (this.weight * 2) * toppingModifier;
            return calories;
        }
        private void SetModifier()
        {
            switch (TypeOfTopping.ToLower())
            {
                case "meat":
                    this.toppingModifier = 1.2;
                    break;
                case "veggies":
                    this.toppingModifier = 0.8;
                    break;
                case "cheese":
                    this.toppingModifier = 1.1;
                    break;
                case "sauce":
                    this.toppingModifier = 0.9;
                    break;
            }
        }
    }
}