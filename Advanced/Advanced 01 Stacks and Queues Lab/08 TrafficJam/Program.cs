using System;
using System.Collections.Generic;

namespace _08_TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int totalCars = 0;
            while (input!="end")
            {
                if (input=="green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count != 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            totalCars++;
                        }
                         
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{totalCars} cars passed the crossroads.");
        }
    }
}
