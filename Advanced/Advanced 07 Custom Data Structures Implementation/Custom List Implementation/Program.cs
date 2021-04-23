using System;

namespace Custom_List_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList list = new CustomList();
            list.Add(5);
            list.Add(8);
            list.Add(11);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.RemoveAt(1));
            list.Insert(2, 6);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine(list.Contains(9));
            list.Swap(1, 2);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
