using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_CupsBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrCups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> cups = new Queue<int>(arrCups);
            Stack<int> bottles = new Stack<int>(arrBottles);
            int wastedWater = 0;
            while (cups.Count != 0 && bottles.Count != 0)
            {
                int litres = bottles.Pop();
                if (litres >= cups.Peek())
                {
                    int waste = litres - cups.Dequeue();
                    wastedWater += waste;
                }
                else
                {
                    int currentcup = cups.Peek()-litres;

                    while (currentcup>0)
                    {
                        if (bottles.Count!=0)
                        {
                            currentcup -= bottles.Pop();
                            if (currentcup <= 0)
                            {
                                wastedWater += Math.Abs(currentcup);
                                cups.Dequeue();
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            if (cups.Count==0)
            {
                Console.WriteLine( $"Bottles: {string.Join(" ", bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
