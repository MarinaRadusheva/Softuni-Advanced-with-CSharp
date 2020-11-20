using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03_WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllLines("../../../words.txt");
            string[] text = File.ReadAllText("../../../text.txt").Split(new char[] { ' ', '.', '-', '?', '!', ':', ';', '\'' },StringSplitOptions.RemoveEmptyEntries).Select(x=>x.ToLower()).ToArray();
            
            Dictionary<string, int> occurrences = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (!occurrences.ContainsKey(words[i]))
                {
                    occurrences.Add(words[i], 0);
                }
            }
            for (int i = 0; i < words.Length; i++)
            {
                string pattern =@"\b"+ $"{words[i].ToLower()}"+@"\b";
                var matches = Regex.Matches(string.Join(" ",text), pattern);
                int count = matches.Count;
                occurrences[words[i]] = count;
            }
            foreach (var word in occurrences)
            {
                File.AppendAllText("../../../actualResults.txt", $"{word.Key} - {word.Value}\n");
            }
            occurrences = occurrences.OrderByDescending(x => x.Value).ToDictionary(a => a.Key, b => b.Value);
            foreach (var word in occurrences)
            {
                File.AppendAllText("../../../expectedResult.txt", $"{word.Key} - {word.Value}\n");
            }
        }
    }
}
