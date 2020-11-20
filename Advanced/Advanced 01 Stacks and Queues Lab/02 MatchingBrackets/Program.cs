using System;
using System.Collections.Generic;

namespace _02_MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5
            string input = Console.ReadLine();
            Stack<int> brackets = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    brackets.Push(i);
                }
                if (input[i]==')')
                {
                    int starInd = brackets.Pop();
                    Console.WriteLine(input.Substring(starInd, i-starInd+1));
                }
            }
        }
    }
}
