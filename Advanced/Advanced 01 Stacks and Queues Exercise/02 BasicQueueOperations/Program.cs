using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int nToEnqueue = input[0];
            int sToDequeue = input[1];
            int xToFind = input[2];
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(nums);

            for (int i = 0; i < sToDequeue; i++)
            {
                queue.Dequeue();

            }
            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(xToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
