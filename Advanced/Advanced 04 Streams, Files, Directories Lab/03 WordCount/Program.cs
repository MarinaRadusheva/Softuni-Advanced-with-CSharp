using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03_WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../words.txt");
            using (reader)
            {
                string[] words = reader.ReadToEnd().ToString().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x=>x.ToLower()).ToArray();
                Dictionary<string, int> counter = new Dictionary<string, int>();
                for (int i = 0; i < words.Length; i++)
                {
                    counter.Add(words[i], 0);
                }
                using (StreamReader textReader = new StreamReader("../../../TextFile1.txt"))
                {
                    string[] textWords = textReader.ReadToEnd().Split(new char[] { ' ', ',', '-', '.' }, StringSplitOptions.RemoveEmptyEntries).Select(x=>x.ToLower()).ToArray();
                    for (int i = 0; i < textWords.Length; i++)
                    {
                        if (counter.ContainsKey(textWords[i]))
                        {
                            counter[textWords[i]]++;
                        }
                    }
                    using (StreamWriter writer = new StreamWriter("../../../result.txt"))
                    {
                        counter = counter.OrderByDescending(x => x.Value).ToDictionary(a => a.Key, b => b.Value);
                        foreach (var item in counter)
                        {
                            writer.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
            
            

        }
    }
}
