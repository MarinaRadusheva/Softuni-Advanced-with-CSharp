using System;

namespace GenericBoxofInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int newInt = int.Parse(Console.ReadLine());
                Box newBox = new Box(newInt);
                Console.WriteLine(newBox.ToString());
            }
        }
    }
}
