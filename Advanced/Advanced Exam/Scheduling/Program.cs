using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taskInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] threadkInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int taskToKill = int.Parse(Console.ReadLine());
            Stack<int> tasks = new Stack<int>(taskInput);
            Queue<int> threads = new Queue<int>(threadkInput);
            while (tasks.Peek() != taskToKill)
            {
                if (threads.Peek() >= tasks.Peek())
                {
                    tasks.Pop();
                }
                threads.Dequeue();
            }
            Console.WriteLine($"Thread with value { threads.Peek()} killed task { taskToKill}");
            Console.WriteLine(string.Join(" ", threads));
        }
    }
}
