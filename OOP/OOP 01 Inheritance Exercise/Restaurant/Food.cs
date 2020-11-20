using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Food : Product
    {
        public Food(string nam, decimal price, double grams) : base(nam, price)
        {
            this.Grams = grams;
        }
        public double Grams { get; set; }
    }
}
