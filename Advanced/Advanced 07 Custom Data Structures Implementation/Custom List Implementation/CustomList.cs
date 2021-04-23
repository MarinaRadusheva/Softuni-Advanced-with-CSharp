using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_List_Implementation
{
    public class CustomList
    {
        private const int InitialCapacity = 2;
        private int[] items;
        public CustomList()
        {
            this.items = new int[InitialCapacity];
        }
        public int Count { get;  private set; }
        public int this[int index]
        {
            get
            {
                if (index>=this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return this.items[index];
            }
            set
            {
                if (index>=this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.items[index] = value;
            }
        }
        public void Add(int element)
        {
            if (this.Count==this.items.Length)
            {
                this.Resize();
            }
            this.items[this.Count] = element;
            this.Count++;
        }

        public int RemoveAt(int index)
        {
            if (index >= this.Count || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int removedItem = this.items[index];
            items[index] = default(int);
            Shift(index);
            this.Count--;
            if (this.Count<=items.Length/4)
            {
                Shrink();
            }
            return removedItem;
        }
        public void Insert(int index, int element)
        {
            if (index > this.Count || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (this.Count==this.items.Length)
            {
                Resize();
            }
            if (index==this.Count)
            {
                this.Add(element);
            }
            else
            {
                this.ShiftRight(index);
                this.items[index] = element;
                this.Count++;
            }

        }
        public bool Contains(int element)
        {
            bool isContained = false;
            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i]==element)
                {
                    isContained = true;
                    break;
                }
            }
            return isContained;
        }
        public void Swap(int firstIdx, int secondIdx)
        {
            if (firstIdx>=this.Count||firstIdx<0||secondIdx>=Count||secondIdx<0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int temp = this.items[firstIdx];
            this.items[firstIdx] = this.items[secondIdx];
            this.items[secondIdx] = temp;
        }
        private void ShiftRight(int index)
        {
            for (int i = this.Count; i > index; i--)
            {
                items[i] = items[i - 1];
            }
        }
        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }
        private void Shift(int index)
        {
            for (int i = index; i < this.Count; i++)
            {
                items[i] = items[i + 1];
            }
        }
        private void Shrink()
        {
            int[] copy = new int[this.items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }
    }
}
