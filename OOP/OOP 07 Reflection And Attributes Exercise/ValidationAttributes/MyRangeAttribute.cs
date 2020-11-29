using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue;
        private int maxValue;
        public MyRangeAttribute(int min, int max)
        {
            this.minValue = min;
            this.maxValue = max;
        }
        public override bool IsValid(object obj)
        {
            int value = (int)obj;
            if (value<minValue||value>maxValue)
            {
                return false;
            }
            return true;
        }
    }
}
