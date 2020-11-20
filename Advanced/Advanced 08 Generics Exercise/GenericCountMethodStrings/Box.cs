using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace GenericCountMethodStrings
{
    public class Box<T> where T: IComparable
    {
        private T something;
        public Box(T input)
        {
            this.something = input;
        }
        public T Something => this.something;

        public override string ToString()
        {
            return $"{Something.GetType()}: {this.Something}";
        }
        public bool CompareTo(T other)
        {
            int result = this.something.CompareTo(other);
           if (result>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
