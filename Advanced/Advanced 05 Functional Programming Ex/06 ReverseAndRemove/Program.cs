using System;
using System.Collections.Generic;
using System.Linq;
namespace _06_ReverseAndRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int divider = int.Parse(Console.ReadLine());
            Predicate<int> isDivisible = x => x % divider == 0;
            Func<int[], Stack<int>> reverser = x =>
            {
                Stack<int> reversed = new Stack<int>();
                for (int i = 0; i < x.Length; i++)
                {
                    if (!isDivisible(x[i]))
                    {
                        reversed.Push(x[i]);
                    }
                }
                return reversed;
            };
            Console.WriteLine(string.Join(" ", reverser(numbers)));
           
        }
    }
}
