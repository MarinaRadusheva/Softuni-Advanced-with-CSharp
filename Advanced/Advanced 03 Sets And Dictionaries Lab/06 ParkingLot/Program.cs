using System;
using System.Collections.Generic;

namespace _06_ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> cars = new HashSet<string>();
            while (input!="END")
            {
                string[] car = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if (car[0]=="IN")
                {
                    cars.Add(car[1]);
                }
                else
                {
                    cars.Remove(car[1]);
                }

                input = Console.ReadLine();
            }
            if (cars.Count!=0)
            {
                foreach (var item in cars)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}
