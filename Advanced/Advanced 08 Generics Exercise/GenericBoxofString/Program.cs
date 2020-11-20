using Microsoft.VisualBasic.CompilerServices;
using System;

namespace GenericBoxofString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Object item = Console.ReadLine();
                Box newBox = new Box(item);
                Console.WriteLine(newBox.ToString());
            }
        }
    }
}
