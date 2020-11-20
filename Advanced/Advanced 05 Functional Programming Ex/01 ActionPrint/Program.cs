using System;

namespace _01_ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printer = x=>{ Console.WriteLine(x); };
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in names)
            {
                printer(item);
            }
        }
    }
}
