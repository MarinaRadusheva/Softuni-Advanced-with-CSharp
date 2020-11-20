using System;
using System.Collections.Generic;

namespace _04_EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> occurrences = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string next = Console.ReadLine();
                if (occurrences.ContainsKey(next))
                {
                    occurrences[next]++;
                }
                else
                {
                    occurrences.Add(next, 1);
                }
            }
            foreach (var item in occurrences)
            {
                if (item.Value%2==0)
                {
                    Console.WriteLine(item.Key);
                    return;
                }
            }
        }
    }
}
