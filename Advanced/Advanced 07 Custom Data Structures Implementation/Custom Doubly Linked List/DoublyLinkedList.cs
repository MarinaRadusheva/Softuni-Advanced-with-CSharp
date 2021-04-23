using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_Doubly_Linked_List
{
    public class DoublyLinkedList
    {
        private class ListNode
        {
            public ListNode(int value)
            {
                this.Value = value;
            }
            public int Value { get; set; }
            public ListNode PreviousNode { get; set; }
            public ListNode NextNode { get; set; }
        }
        private ListNode head;
        private ListNode tail;
        public int Count { get; private set; }

        public void AddFirst(int value)
        {
            if (this.Count == 0)
            {
                this.head = new ListNode(value);
                this.tail = this.head;

            }
            else
            {
                ListNode newHead = new ListNode(value);
                newHead.NextNode = this.head;
                this.head.PreviousNode = newHead;
                this.head = newHead;
            }
            this.Count++;
        }
        public void AddLast(int value)
        {
            if (this.Count == 0)
            {
                this.head = new ListNode(value);
                this.tail = this.head;
            }
            else
            {
                ListNode newTail = new ListNode(value);
                newTail.PreviousNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }
            this.Count++;
        }
        public int RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            int firstElement = this.head.Value;
            if (this.Count == 1)
            {
                this.head = this.tail = null;
            }
            else
            {
                this.head = this.head.NextNode;
                this.head.PreviousNode = null;
            }
            this.Count--;
            return firstElement;
        }
        public int RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            int lastElement = this.tail.Value;
            this.tail = this.tail.PreviousNode;
            if (this.tail == null)
            {
                this.head = null;
            }
            else
            {
                this.tail.NextNode = null;
            }
            this.Count--;
            return lastElement;
        }
        public void ForEach(Action<int> action)
        {
            ListNode currentNode = this.head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }
        public int[] ToArray()
        {
            int[] array = new int[this.Count];
            ListNode current = this.head;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = current.Value;
                current = current.NextNode;
            }
            return array;
        }
    }
}
