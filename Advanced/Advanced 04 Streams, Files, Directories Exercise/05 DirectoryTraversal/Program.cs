using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05_DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> allFiles = new Dictionary<string, Dictionary<string, double>>();
            DirectoryInfo directory = new DirectoryInfo("../../../");
            var directoryContent = directory.GetFiles();
            for (int i = 0; i < directoryContent.Length; i++)
            {
                string currentName = directoryContent[i].Name;
                string extension = directoryContent[i].Extension;
                double size = (double)directoryContent[i].Length / 1024;
                FillDictionary(allFiles, currentName, extension, size);
                allFiles = allFiles.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);
            }
            using (StreamWriter writer = new StreamWriter(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\report.txt"))
            {
                foreach (var item in allFiles)
                {
                    writer.WriteLine(item.Key);
                    foreach (var file in item.Value.OrderBy(x => x.Value))
                    {
                        writer.WriteLine($"--{file.Key} - {file.Value:F3}kb");
                    }
                }
            }
            
        }

        private static void FillDictionary(Dictionary<string, Dictionary<string, double>> allFiles, string currentName, string extension, double size)
        {
            if (!allFiles.ContainsKey(extension))
            {
                allFiles.Add(extension, new Dictionary<string, double>());
                allFiles[extension].Add(currentName, size);
            }
            else
            {
                if (!allFiles[extension].ContainsKey(currentName))
                {
                    allFiles[extension].Add(currentName, size);
                }

            }
        }
    }
}
