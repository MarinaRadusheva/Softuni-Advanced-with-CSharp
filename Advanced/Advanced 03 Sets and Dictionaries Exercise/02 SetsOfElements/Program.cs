using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lengths = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondtSet = new HashSet<int>();
            for (int i = 0; i < lengths[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }
            for (int i= 0; i < lengths[1]; i++)
            {
                secondtSet.Add(int.Parse(Console.ReadLine()));
            }
            List<int> nums = new List<int>();
            foreach (var num in firstSet)
            {
                if (!secondtSet.Contains(num))
                {
                    nums.Add(num);
                }
            }
            for (int i = 0; i < nums.Count; i++)
            {
                firstSet.Remove(nums[i]);
            }
            Console.WriteLine(string.Join(" ", firstSet));
        }
    }
}
