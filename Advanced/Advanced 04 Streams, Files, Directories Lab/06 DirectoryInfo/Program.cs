using System;
using System.IO;

namespace _06_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[]files = Directory.GetFiles("../../../../05 SliceAFile");
            double sum = 0;
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo fileinfo = new FileInfo(files[i]);
                string toAppend = fileinfo.Name + "-- > " + fileinfo.Length + Environment.NewLine;
                File.AppendAllText("../../../size.txt",toAppend);
                
                sum += fileinfo.Length;
            }
            sum =sum/1024;
            File.AppendAllText("../../../size.txt", $"{ sum.ToString()} MB");
       
        }
    }
}
