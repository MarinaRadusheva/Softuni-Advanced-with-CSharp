using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIteratorProblem
{
    public class ListyIterator<T>
    {
        private List<T> myList;
        int index;
        public ListyIterator(T[] elements)
        {
            this.myList = elements.ToList();
            this.index = 0;
        }
        public bool Move()
        {
            return ++this.index < this.myList.Count;
        }
        public void Print()
        {
            if (this.myList.Count==0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(this.myList[index]);
        }
        public bool HasNext()
        {
            return this.myList.Count>this.index+1;
        }

    }
}
