using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
            
        }
        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value)||value.Length<1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }
        public Dough Dough
        {
            private get; set;
        }
        
        public int ToppingCount { get => this.toppings.Count; }
        public void AddTopping(Topping topping)
        {
            if (this.ToppingCount == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.toppings.Add(topping);
        }
        public double TotalCalories
        {
            get => CalculateTotalCalories();
        }
        private double CalculateTotalCalories()
        {
            double totalCalories = 0;
            totalCalories += this.Dough.DoughCalories;
            if (this.ToppingCount != 0)
            {
                foreach (var topping in this.toppings)
                {
                    totalCalories += topping.ToppingCalories;
                }
            }

            return totalCalories;
        }
    }
}
