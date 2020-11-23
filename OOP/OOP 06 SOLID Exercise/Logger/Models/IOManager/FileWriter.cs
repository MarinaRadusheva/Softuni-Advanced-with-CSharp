
using Logger.Models.Contracts;
using System;
using System.IO;

namespace Logger.Models.IOManager
{
    public class FileWriter : IWriter
    {
        public FileWriter(string path)
        {
            this.FilePath = path;
        }
        string FilePath { get; }
        public void Write(string text)
        {
            File.WriteAllText(this.FilePath,text);
        }

        public void WriteLine(string text)
        {
            File.AppendAllText(this.FilePath, text + Environment.NewLine);
        }
    }
}
