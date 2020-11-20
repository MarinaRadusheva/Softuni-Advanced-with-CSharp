using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletCost = int.Parse(Console.ReadLine());
            int barrelCap = int.Parse(Console.ReadLine());
            int[] arrayBullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrayLockss = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int price = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(arrayBullets);
            Queue<int> locks = new Queue<int>(arrayLockss);
            int bulletsCount = 0;
            while (bullets.Count!=0 && locks.Count!=0)
            {
                if (locks.Peek()>=bullets.Pop())
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                bulletsCount++;
                if (bulletsCount % barrelCap == 0 && bullets.Count != 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }
            if (locks.Count==0)
            {
                int earnings = price - (bulletsCount * bulletCost);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${earnings}");

            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
