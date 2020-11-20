using System;
using System.IO;

namespace _04_MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../TextFile1.txt"))
            {
                using (StreamReader reader2 = new StreamReader("../../../TextFile2.txt"))
                {
                    using (StreamWriter writer = new StreamWriter("../../../result.txt"))
                    {

                        bool end = false;
                        while (end == false)
                        {
                            if (!reader.EndOfStream)
                            {
                                writer.WriteLine(reader.ReadLine());
                            }
                            if (!reader2.EndOfStream)
                            {
                                writer.WriteLine(reader2.ReadLine());
                            }

                            if (reader.EndOfStream&&reader2.EndOfStream)
                            {
                                end = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
