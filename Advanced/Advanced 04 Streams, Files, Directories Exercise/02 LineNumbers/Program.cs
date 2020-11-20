using System;
using System.Collections.Generic;
using System.IO;

namespace _02_LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../input.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];
                int letters = CountLetters(currentLine);
                int marks = CountMarks(currentLine);
                lines[i] = $"Line {i + 1}: {currentLine} ({letters})({marks})";
            }
            File.WriteAllLines("../../../result.txt", lines);
        }

        static int CountLetters(string line)
        {
            int letters = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (char.IsLetter(line[i]))
                {
                    letters++;
                }
            }
            return letters;
        }

        static int CountMarks(string line)
        {
            int marks = 0;
            for (int i = 0; i < line.Length; i++)
            {
                char current = line[i];
                List<char> allMarks = new List<char>() { '.', ',', ':', ';', '\'', '?', '!', '-' };
                if (allMarks.Contains(current))
                {
                    marks++;
                }
            }
            return marks;
        }
    }
}
