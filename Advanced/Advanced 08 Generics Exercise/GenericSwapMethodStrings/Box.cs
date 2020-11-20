using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
{
    public class Box
    {
        private Object something;
        public Box(Object item)
        {
            this.something = item;
        }
        public override string ToString()
        {
            return $"{this.something.GetType()}: {this.something.ToString()}";
        }
        
    }
}
