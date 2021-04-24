using System;

namespace Custom_Stack_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack stack = new CustomStack();
            stack.Push(5);
            stack.Push(7);
            stack.Push(2);
            stack.Push(4);
            stack.Push(7);
            stack.Push(6);
            stack.Push(3);
            stack.Push(1);
            stack.Pop();
            Console.WriteLine(stack.Peek());
            stack.ForEach(x=>Console.WriteLine(x));
        }
    }
}
