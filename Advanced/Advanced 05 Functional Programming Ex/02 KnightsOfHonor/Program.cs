using System;

namespace _02_KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Action<string> printer = x =>
            {
                Console.WriteLine($"Sir {x}");
            };
            foreach (var item in names)
            {
                printer(item);
            }
        }
    }
}
