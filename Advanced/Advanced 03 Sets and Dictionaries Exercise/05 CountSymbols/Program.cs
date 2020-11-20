using System;
using System.Collections.Generic;

namespace _05_CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                char next = input[i];
                if (symbols.ContainsKey(next))
                {
                    symbols[next]++;
                }
                else
                {
                    symbols.Add(next, 1);
                }
            }
            foreach (var item in symbols)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
