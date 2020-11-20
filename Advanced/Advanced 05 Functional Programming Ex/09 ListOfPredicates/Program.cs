using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());           
            HashSet<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToHashSet();
            List < Predicate<int> > predicatesList = new List<Predicate<int>>();
            foreach (var num in dividers)
            {
                predicatesList.Add(x => x % num == 0);
            }
            for (int i = 1; i <=n; i++)
            {
                bool isDivisible = false;
                foreach (var item in predicatesList)
                {
                    isDivisible = item(i);
                    if (isDivisible==false)
                    {
                        break;
                    }
                }
                if (isDivisible)
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
