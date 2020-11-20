using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<string> shoppingbag;
        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.shoppingbag = new List<string>();
        }
        public string Name 
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        private double Money
        {
            get => this.money;
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }
        public void BuyProduct(Product product)
        {
            if (this.Money<product.Cost)
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
            else
            {
                this.Money -= product.Cost;
                this.shoppingbag.Add(product.Name);
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }          
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Name} - ");
            if (this.shoppingbag.Count==0)
            {
                sb.Append("Nothing bought");
            }
            else
            {                
                sb.Append(string.Join(", ",this.shoppingbag));
            }
            return sb.ToString().TrimEnd();
        }
    }
}
