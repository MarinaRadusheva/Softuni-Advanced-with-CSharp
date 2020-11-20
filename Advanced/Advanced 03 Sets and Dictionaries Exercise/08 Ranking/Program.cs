using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string contest = Console.ReadLine();
            Dictionary<string, string> contests = new Dictionary<string, string>();
            while (contest!= "end of contests")
            {
                string[] contestArray = contest.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string subject = contestArray[0];
                string password = contestArray[1];
                if (!contests.ContainsKey(subject))
                {
                    contests.Add(subject, password);
                }
                contest = Console.ReadLine();
            }
            contest = Console.ReadLine();
            SortedDictionary<string, Student> participants = new SortedDictionary<string, Student>();
            while (contest!= "end of submissions")
            {
                //"{contest}=>{password}=>{username}=>{points}
                string[] entry = contest.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string subj = entry[0];
                string pass = entry[1];
                if (contests.ContainsKey(subj))
                {
                    if (contests[subj]==pass)
                    {
                        string student = entry[2];
                        int points = int.Parse(entry[3]);
                        if (!participants.ContainsKey(student))
                        {
                            Student newStudent = new Student(student, new Dictionary<string, int>());
                            newStudent.subjects.Add(subj, points);
                            participants.Add(student, newStudent);
                        }
                        else
                        {
                            if (!participants[student].subjects.ContainsKey(subj))
                            {
                                participants[student].subjects.Add(subj, points);
                            }
                            else
                            {
                                if (participants[student].subjects[subj]<points)
                                {
                                    participants[student].subjects[subj] = points;
                                }
                            }
                        }
                    }
                }
                contest = Console.ReadLine();
            }
            int maxPoints = -1;
            string smartest = "";
            foreach (var item in participants)
            {
                int total = item.Value.SumPoints();
                if (total>maxPoints)
                {
                    maxPoints = total;
                    smartest = item.Key;
                }
            }
            Console.WriteLine($"Best candidate is {smartest} with total {maxPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var item in participants)
            {
                Console.WriteLine(item.Key);
                var sortedSubjects = item.Value.subjects.OrderByDescending(x => x.Value).ToDictionary(a => a.Key, b => b.Value);
                foreach (var subj in sortedSubjects)
                {
                    Console.WriteLine($"#  {subj.Key} -> {subj.Value}");
                }
            }
        }
    }

    public class Student
    {
        public string name { get; set; }
        public Dictionary<string, int> subjects { get; set; }
        public Student(string name, Dictionary<string, int> subjects)
        {
            this.name = name;
            this.subjects = subjects;
        }

        public int SumPoints()
        {
            int totalPoints = 0;
            foreach (var item in this.subjects)
            {
                totalPoints += item.Value;
            }
            return totalPoints;
        }
    }
}
