using System;
using System.Collections.Generic;

namespace _07_HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alva James William --> 2
            string[] input= Console.ReadLine().Split();
            Queue<string> children = new Queue<string>(input);
            int n = int.Parse(Console.ReadLine());
            
            while (children.Count!=1)
            {
                for (int i = 0; i < n-1; i++)
                {
                    children.Enqueue(children.Dequeue());
                }
                Console.WriteLine( $"Removed {children.Dequeue()}" );
            }
            Console.WriteLine($"Last is {children.Peek()}");
            
        }
    }
}
