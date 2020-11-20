using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 + 5 + 10 - 2 - 1
            string[] input = Console.ReadLine().Split(' ').Reverse().ToArray();
            //1-2-10+5+2
            Stack<string> operations = new Stack<string>(input);
            while (operations.Count>1)
            {
                int first = int.Parse(operations.Pop());
                string op = operations.Pop();
                int second = int.Parse(operations.Pop());
                int result = 0;
                switch (op)
                {
                    case "+":
                        result = first + second;
                        break;
                    case "-":
                        result = first - second;
                        break;
                    default:
                        break;
                }
                operations.Push(result.ToString());
            }
            Console.WriteLine(operations.Pop());
        }
    }
}
