using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace _05_AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            
            while (command!="end")
            {
                if (command=="print")
                {
                    Console.WriteLine(string.Join(" ", nums));
                }
                else
                {
                    for (int i = 0; i < nums.Length; i++)
                    {
                        nums[i] = Operation(command)(nums[i]);
                    }
                    
                }
                command = Console.ReadLine();
            }

            static Func<int, int> Operation(string command)
            {
                
                switch (command)
                {
                    case "add": return x => x + 1;
                    case "multiply": return x => x * 2;
                    case "subtract": return x => x - 1;
                    default:
                        return null;
                }
            }
        }
    }
}
