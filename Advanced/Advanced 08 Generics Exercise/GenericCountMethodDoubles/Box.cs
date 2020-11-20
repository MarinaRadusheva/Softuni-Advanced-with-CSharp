using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodDoubles
{
    public class Box<T> where T: IComparable
    {
        public List<T> items { get; set; }
        public Box(List<T> items)
        {
            this.items = items;
        }
        
        public int GetCountOfHigherValues(T value)
        {
            int count = 0;
            foreach (var item in this.items)
            {
                if ((item.CompareTo(value))>0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
