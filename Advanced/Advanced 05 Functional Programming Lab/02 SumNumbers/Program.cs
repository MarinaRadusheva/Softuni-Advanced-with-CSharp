using System;
using System.Linq;

namespace _02_SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Func<int[], int> counter = n => n.Count();
            Console.WriteLine(counter(numbers));
            Func<int[], int> sum = n => n.Sum();
            Console.WriteLine(sum(numbers));
        }

        
    }
}
