using System;
using System.Collections.Generic;
using System.Text;

namespace _09_SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> textBeforeCommands = new Stack<string>(); 
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] command = input.Split();
                switch (command[0])
                {
                    case "1":
                        textBeforeCommands.Push(text.ToString());
                        string textToAppend = command[1];
                        text.Append(textToAppend);
                        
                        break;
                    case "2":
                        textBeforeCommands.Push(text.ToString());
                        int count = int.Parse(command[1]);
                        if (text.Length==count)
                        {
                            text.Clear();
                        }
                        else
                        {
                            text.Remove(text.Length - count, count);
                        }
                        
                        
                        break;
                    case "3":
                        int indexOfChar = int.Parse(command[1]);
                        Console.WriteLine(text[indexOfChar-1]);
                        break;
                    case "4":
                        text.Clear();
                        text.Append(textBeforeCommands.Pop());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
