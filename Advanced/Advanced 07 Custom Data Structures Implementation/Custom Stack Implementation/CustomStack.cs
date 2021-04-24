using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_Stack_Implementation
{
    public class CustomStack
    {
        private const int InitialCapacity = 4;
        private int[] items;
        private int count;
        public CustomStack()
        {
            this.count = 0;
            this.items = new int[InitialCapacity];
        }
        public int Count { get => this.count; }
        public void Push(int element)
        {
            if (this.count==this.items.Length)
            {
                Resize();
            }
            this.items[count] = element;
            count++;
        }
        public int Pop()
        {
            if (items.Length==0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            int lastIndex = this.count - 1;
            int removedItem = this.items[lastIndex];
            this.items[lastIndex] = default(int);
            count--;
            return removedItem;
        }

        public int Peek()
        {
            if (items.Length == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            int item = this.items[count - 1];
            return item;
        }
        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < this.count; i++)
            {
                action(this.items[i]);
            }
        }
        private void Resize()
        {
            int[] copy = new int[items.Length * 2];
            for (int i = 0; i < this.count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }
    }
}
