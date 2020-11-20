using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>(input);
            string nextAction = Console.ReadLine().ToLower();
            while (nextAction != "end")
            {


                string[] command = nextAction.Split(' ');
                if (command[0] == "add")
                {
                    numbers.Push(int.Parse(command[1]));
                    numbers.Push(int.Parse(command[2]));
                }
                else
                {
                    int count = int.Parse(command[1]);
                    if (count <= numbers.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
                nextAction = Console.ReadLine().ToLower();
            }
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
