using System;
using System.Collections.Generic;

namespace _01_ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> chars = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                chars.Push(input[i]);
            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(chars.Pop());
            }
        }
    }
}
