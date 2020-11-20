using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Threading.Tasks.Dataflow;

namespace GenericCountMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> strings = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                Box<string> newBox = new Box<string>(Console.ReadLine());
                strings.Add(newBox);
            }
            string value = Console.ReadLine();
            int count = GetCountOfHigherValues(strings, value);
            Console.WriteLine(count);
        }
        public static int GetCountOfHigherValues(List<Box<string>> boxes, string value)
        {
            int count = 0;
            foreach (var box in boxes)
            {
                if (box.CompareTo(value))
                {
                    count++; 
                }
            }
            return count;
        }
    }
}
