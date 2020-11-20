using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class Threeuple<item1, item2, item3>
    {
        public item1 First { get; set; }
        public item2 Second { get; set; }
        public item3 Third { get; set; }
        public Threeuple(item1 value1, item2 value2, item3 value3)
        {
            this.First = value1;
            this.Second = value2;
            this.Third = value3;
        }
        public override string ToString()
        {
            return $"{this.First.ToString()} -> {this.Second.ToString()} -> {this.Third.ToString()}";
        }
    }
}
