using System;
using System.Collections;
using System.Collections.Immutable;
using System.Linq;

namespace _08_CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            static int Com(int x, int y)
            {
                int sorter = 0;
                if (x%2==0&&y%2!=0)
                {
                    sorter = -1;
                }
                else if (x%2!=0&&y%2==0)
                {
                    sorter = 1;
                }
                else
                {
                    sorter = x.CompareTo(y);
                }
                return sorter;
            }

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(nums, (x,y)=>Com(x,y));
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
