using System;
using System.IO;

namespace _02_LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../result.txt"))
                {
                    int counter = 1;
                    while (!reader.EndOfStream)
                    {
                        
                        string line = reader.ReadLine();
                        writer.WriteLine($"{counter}. - {line}");
                        counter++;

                    }
                }
            }
        }
    }
}
