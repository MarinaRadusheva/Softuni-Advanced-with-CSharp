using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class MainDish : Food
    {
        public MainDish(string nam, decimal price, double grams) : base(nam, price, grams)
        {
        }
    }
}
