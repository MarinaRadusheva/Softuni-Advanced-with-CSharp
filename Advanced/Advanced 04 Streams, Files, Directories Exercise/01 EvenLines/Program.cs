using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01_EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                int counter = 0;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (counter % 2 == 0)
                    {
                        string pattern = @"[-,.!?']";
                        line = Regex.Replace(line, pattern, "@");
                        List<string> lineWords = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();
                        Console.WriteLine(string.Join(" ", lineWords));
                    }
                    counter++;
                }
            }
        }
    }
}
