using System;
using System.Collections.Generic;

namespace _03_PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] newElements = Console.ReadLine().Split();
                for (int j = 0; j < newElements.Length; j++)
                {
                    elements.Add(newElements[j]);
                }
                
            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
