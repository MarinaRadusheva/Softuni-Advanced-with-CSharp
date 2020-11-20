using System;
using System.IO;

namespace _04_CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream reader = new FileStream("../../../picToCopy.jpg", FileMode.Open))
            {
                using (FileStream writer = new FileStream("../../../copy.jpg", FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    while (reader.CanRead)
                    {
                        int bytesRead = reader.Read(buffer, 0, buffer.Length);
                        if (bytesRead == 0)
                        {
                            return;
                        }
                        writer.Write(buffer, 0, buffer.Length);
                        
                    }
                    
                }
            }
        } 
    }
}
