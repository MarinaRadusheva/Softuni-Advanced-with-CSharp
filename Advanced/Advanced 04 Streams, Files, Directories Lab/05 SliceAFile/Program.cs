using System;
using System.IO;

namespace _05_SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int piecesCount = 4;
            using (FileStream stream = new FileStream("../../../TextToSlice.txt", FileMode.Open))
            {
                long size = stream.Length / piecesCount;
                //var size = (long)Math.Ceiling((double)stream.Length / piecesCount);
                for (int i = 0; i < piecesCount; i++)
                {
                    
                    using (var partStream = new FileStream($"../../../part-{i + 1}.txt", FileMode.Create))
                    {
                        byte[] buffer = new byte[1];
                        long count = 0;
                        while (count<size)
                        {
                            stream.Read(buffer, 0, buffer.Length);
                            partStream.Write(buffer, 0, buffer.Length);
                            count += buffer.Length;
                        }
                    }
                }
            }
        }
    }
}
