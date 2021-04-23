using System;

namespace Custom_Doubly_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList dll = new DoublyLinkedList();
            dll.AddFirst(5);
            dll.AddFirst(3);
            dll.AddLast(7);
            dll.AddLast(9);
            Console.WriteLine(dll.RemoveFirst());
            Console.WriteLine(dll.RemoveLast());
            dll.ForEach(x => Console.WriteLine(x));
            int[] listToArray = dll.ToArray();
            Console.WriteLine(string.Join(" ", listToArray));
        }
    }
}
