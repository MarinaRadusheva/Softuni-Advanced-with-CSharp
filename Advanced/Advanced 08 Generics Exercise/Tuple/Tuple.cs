using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple<item1, item2>
    {
        public item1 First { get; set; }
        public item2 Second { get; set; }
        public Tuple(item1 value, item2 value2)
        {
            this.First = value;
            this.Second = value2;
        }
        public override string ToString()
        {
            return $"{ this.First.ToString()} -> {this.Second.ToString()}";
        }
    }
}
