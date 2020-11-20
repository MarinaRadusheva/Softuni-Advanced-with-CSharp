using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_CountSameValues
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Dictionary<double, int> values = new Dictionary<double, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (values.ContainsKey(input[i]))
                {
                    values[input[i]]++;
                }
                else
                {
                    values.Add(input[i],1);
                }
            }
            foreach (var item in values)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
