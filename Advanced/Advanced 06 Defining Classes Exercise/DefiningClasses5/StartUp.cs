using DefiningClasses;
using System;
using System.Runtime.CompilerServices;

namespace DefiningClasses5
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();
            DateModifier newModifier = new DateModifier();           
            int days = newModifier.GetDifference(date1, date2);
            Console.WriteLine(days);
        }
    }
}
