using System;
using System.Linq;

namespace _03_CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> isUpper = x => x[0] == x.ToUpper()[0];
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(isUpper).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine,words));
        }
    }
}
