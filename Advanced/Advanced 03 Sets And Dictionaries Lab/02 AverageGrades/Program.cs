using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] nextGrade = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = nextGrade[0];
                decimal grade = decimal.Parse(nextGrade[1]);
                if (grades.ContainsKey(name))
                {
                    grades[name].Add(grade);
                }
                else
                {
                    grades.Add(name, new List<decimal> { grade });
                }
            }
            foreach (var student in grades)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var grade in student.Value)
                {
                    sb.Append($"{grade:f2} ");
                }
                Console.WriteLine($"{student.Key} -> {sb}(avg: {student.Value.Average():f2})");
            }
        }
    }
}
