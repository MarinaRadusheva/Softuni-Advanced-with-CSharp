using System;
using System.IO;

namespace _01_OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../text.txt");
            int count = 0;
            StreamWriter writer = new StreamWriter("../../../oddLines.txt");
            while (!reader.EndOfStream)
            {
                
                string line = reader.ReadLine();
                if (count%2!=0)
                {
                    writer.WriteLine(line);
                }
                count++;
            }
            reader.Close();
            writer.Close();
        }
    }
}
