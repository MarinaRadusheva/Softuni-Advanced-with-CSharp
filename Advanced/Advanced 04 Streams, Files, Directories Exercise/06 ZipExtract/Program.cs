using System;
using System.IO.Compression;

namespace _06_ZipExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\Users\Marina\Desktop\PB\ZipDemo";
            string zipPath = @"C:\Users\Marina\Desktop\PB\ZipDemoZipped\result.zip";
            ZipFile.CreateFromDirectory(directoryPath, zipPath);
            ZipFile.ExtractToDirectory(zipPath, "../../../");
        }
    }
}
