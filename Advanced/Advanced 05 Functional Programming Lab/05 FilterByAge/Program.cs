using System;
using System.Collections.Generic;

namespace _05_FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();            
            for (int i = 0; i < n; i++)
            {
                string[] newStudent = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                students.Add(CreateStudent(newStudent));
            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<Student, bool> conditionDelegate = GetCondition(condition, age);
            Action<Student> printStudent = GetFormat(format);
            foreach (var item in students)
            {
                if (conditionDelegate(item))
                {
                    printStudent(item);
                }
            }
        }
       
        static Action<Student> GetFormat(string format)
        {
            switch (format)
            {
                case "name": return s => Console.WriteLine($"{s.Name}");
                case "age": return s => Console.WriteLine(s.Age);
                case "name age": return s => Console.WriteLine($"{s.Name} - {s.Age}");
                default:
                    return null;
            }
        }
        static Func<Student, bool> GetCondition(string condition, int age)
        {
            switch (condition)
            {
                case "older":
                    return x => x.Age >= age;
                case "younger":
                    return x => x.Age < age;
                default:
                    return null;
            }
        }
        static Student CreateStudent(string[] array)
        {
            Student newStudent = new Student(array[0], int.Parse(array[1]));
            return newStudent;
        }
        

    }
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        
    }
}
