using System;
using System.Collections.Generic;

namespace _08_BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();                                 
            if (input.Length%2==1)
            {
                Console.WriteLine("NO");
                return;
            }
            Stack<char> lastPar = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='('||input[i]=='{'||input[i]=='[')
                {
                    lastPar.Push(input[i]);
                }
                else
                {
                    switch (input[i])
                    {
                        case ')':
                            if (lastPar.Peek()=='(')
                            {
                                lastPar.Pop();
                            }
                            else
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case '}':
                            if (lastPar.Peek() == '{')
                            {
                                lastPar.Pop();
                            }
                            else
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ']':
                            if (lastPar.Peek() == '[')
                            {
                                lastPar.Pop();
                            }
                            else
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
