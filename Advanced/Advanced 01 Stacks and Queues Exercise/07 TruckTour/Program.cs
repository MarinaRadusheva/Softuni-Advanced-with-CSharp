using System;
using System.Collections.Generic;

namespace _07_TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumpsCount = int.Parse(Console.ReadLine());
            Queue<string> pumps = new Queue<string>();
            for (int i = 0; i < pumpsCount; i++)
            {
                string nextPump = Console.ReadLine();
                pumps.Enqueue(nextPump + " " + i);
            }
            int fuelTank = 0;
            bool complete = false;
            //       0     7
            //1 5   10 3   3 4
            //10 3   3 4   1 5
            //3 4   1 5     10 3
            int stops = 0;
            while(!complete)
            {
                                  
                    string[] info = pumps.Peek().Split();
                    int fuel = int.Parse(info[0]);
                    int distance = int.Parse(info[1]);
                    fuelTank += fuel;
                    if (fuelTank < distance)
                    {
                        pumps.Enqueue(pumps.Dequeue());
                        fuelTank = 0;
                        stops = 0;
                        complete = false;
                    }
                    else
                    {
                        fuelTank -= distance;
                        stops++;
                        if (stops==pumpsCount)
                        {
                        complete = true;
                        }
                        pumps.Enqueue(pumps.Dequeue());
                        
                    }
                
            }
            string[] index = pumps.Dequeue().Split();
            Console.WriteLine(index[2]);
        }
    }
}
