using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;

namespace _04_FindEvenOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] margins = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = margins[0];
            int end = margins[1];
            string type = Console.ReadLine();
            Predicate<int> even = x => x % 2 == 0;
            
            switch (type)
            {
                case "even":
                    for (int i = start; i <= end; i++)
                    {
                        if (even(i))
                            Console.Write(i+" ");
                    }
                    break;
                case "odd":
                    for (int i = start; i <= end; i++)
                    {
                        if (!even(i))
                        {
                            Console.Write(i+" ");
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
