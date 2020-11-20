using System;
using System.IO.Compression;

namespace _06_ZipAmdExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"../../../quinoa.jpg";
            string zipPath = @"../../../result.zip";
            string extractPath = @"\extractFile";
            ZipFile.CreateFromDirectory("../../../quinoq.jpg", "../../../");

        }
    }
}
