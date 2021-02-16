using System;
using System.Linq;

namespace SumOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(SumOfArray(array, 0));
        }
        public static int SumOfArray(int[] array, int index)
        {
            int result = array[index];
            if (index ==array.Length-1)
            {
                return result;
            }
            result += SumOfArray(array, index + 1);
            return result;
        }
    }
}
