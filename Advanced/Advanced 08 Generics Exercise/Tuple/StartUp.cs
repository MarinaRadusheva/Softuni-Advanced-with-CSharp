using System;
using System.Collections.Concurrent;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameAddress = Console.ReadLine().Split();
            string name = nameAddress[0] +" "+ nameAddress[1];
            string address = nameAddress[2];
            Tuple<string, string> nameAdr = new Tuple<string, string>(name, address);           
            string[] nameLitres = Console.ReadLine().Split();
            Tuple<string, int> consumedBeer = new Tuple<string, int>(nameLitres[0], int.Parse(nameLitres[1]));          
            string[] nums = Console.ReadLine().Split();
            Tuple<int, double> intDouble= new Tuple<int, double>(int.Parse(nums[0]), double.Parse(nums[1]));
            Console.WriteLine(nameAdr);
            Console.WriteLine(consumedBeer);
            Console.WriteLine(intDouble);
        }
    }
}
