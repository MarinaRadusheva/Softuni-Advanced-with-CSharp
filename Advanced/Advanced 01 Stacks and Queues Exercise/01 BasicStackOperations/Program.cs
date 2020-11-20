using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01_BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int nToPush = input[0];
            int sToPop = input[1];
            int xToFind = input[2];
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(nums);
            
            for (int i = 0; i < sToPop; i++)
            {
                stack.Pop();

            }
            if (stack.Count==0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(xToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
