using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace _04_FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQtty = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(nums);
            Console.WriteLine(orders.Max());
            while (orders.Count!=0)
            {
                if (foodQtty >= orders.Peek())
                {
                    
                    foodQtty -= orders.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (orders.Count!=0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
