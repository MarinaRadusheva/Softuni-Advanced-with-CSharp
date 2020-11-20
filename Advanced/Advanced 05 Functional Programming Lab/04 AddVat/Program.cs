using System;
using System.Linq;

namespace _04_AddVat
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, double> vatCalc = x => double.Parse(x)*1.20;
            double[] prices = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(vatCalc).ToArray();
            foreach (var item in prices)
            {
                Console.WriteLine($"{item:f2}");
            }
            
        }
    }
}
