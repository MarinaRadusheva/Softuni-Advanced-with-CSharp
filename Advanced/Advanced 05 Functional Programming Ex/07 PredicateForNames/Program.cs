using System;

namespace _07_PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Predicate<string> isShorter = x => x.Length <= len;
            for (int i = 0; i < names.Length; i++)
            {
                if (isShorter(names[i]))
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
    }
}
