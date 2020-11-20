using System;
using System.Linq;

namespace _03_CustomMinValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Func<int[], int> getMin = x =>
            {
                int min = int.MaxValue;
                foreach (var item in x)
                {
                    if (item<min)
                    {
                        min = item;
                    }                   
                }
                return min;
            };
            Console.WriteLine(getMin(nums));
        }
    }
}
