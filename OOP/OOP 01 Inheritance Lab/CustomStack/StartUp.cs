using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            stack.Push("pesho");
            stack.Push("gosho");
            stack.Push("tosho");
            stack.Push("mosho");
            Stack<string> range = new Stack<string>();
            range.Push("Pepa");
            range.Push("Momepa");
            Console.WriteLine(stack.IsEmpty());
            stack.AddRange(range);
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
