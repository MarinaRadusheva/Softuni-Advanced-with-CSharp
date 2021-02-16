using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int wanted = int.Parse(Console.ReadLine());
            Console.WriteLine(BinarySearch(nums, wanted));
            
        }
        private static int BinarySearch(int[] array, int num)
        {
            int lo = 0;
            int hi = array.Length - 1;
            
            while (lo<=hi)
            {
                int midIndex = lo + ((hi - lo) / 2);
                if (array[midIndex] > num)
                {
                    hi = midIndex - 1;
                }
                else if (array[midIndex] < num)
                {
                    lo = midIndex + 1;
                }
                else
                {
                    return midIndex;
                }
            }
            
            return -1;
        }
    }
}
