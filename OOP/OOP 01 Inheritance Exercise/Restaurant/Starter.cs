using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Starter : Food
    {
        public Starter(string nam, decimal price, double grams) : base(nam, price, grams)
        {
        }
    }
}
