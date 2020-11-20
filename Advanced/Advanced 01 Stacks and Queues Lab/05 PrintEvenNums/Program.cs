using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_PrintEvenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 2 3 4 5 6 ----> 2, 4, 6
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> evenNums = new Queue<int>(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (evenNums.Peek()%2==0)
                {
                    evenNums.Enqueue(evenNums.Dequeue());
                }
                else
                {
                    evenNums.Dequeue();
                }
            }
            Console.WriteLine(string.Join(", ", evenNums));
        }
    }
}
