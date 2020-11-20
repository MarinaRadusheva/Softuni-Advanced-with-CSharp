using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> myBox=new Stack<T>();
        public int Count => myBox.Count;

        public void Add(T element)
        {
            myBox.Push(element);
        }
        public T Remove()
        {
            return myBox.Pop();
        }

    }
}
