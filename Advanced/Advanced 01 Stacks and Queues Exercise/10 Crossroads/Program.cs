using System;
using System.Collections.Generic;

namespace _10_Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenSeconds = int.Parse(Console.ReadLine());
            int afterGreenWindow = int.Parse(Console.ReadLine());
            int totalCarsPassed = 0;
            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            while (input != "END")
            {
                if (input == "green")
                {
                    int greenCountdown = greenSeconds;
                    while (cars.Count>0 && greenCountdown!=0)
                    {
                        string nextcar = cars.Dequeue();
                        if (greenCountdown>=nextcar.Length)
                        {
                            
                            greenCountdown -= nextcar.Length;
                            totalCarsPassed++;
                            Console.WriteLine(nextcar + " passed");
                        }
                        else
                        {
                            if (greenCountdown+afterGreenWindow>=nextcar.Length)
                            {
                                totalCarsPassed++;
                                greenCountdown = 0;
                                Console.WriteLine(nextcar+" passed");
                            }
                            else
                            {
                                char hitPoint = nextcar[greenCountdown + afterGreenWindow];
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{nextcar} was hit at {hitPoint}.");
                                return;

                            }
                        }
                    }                    
                }
                else
                {
                    cars.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
        }
    }
}
