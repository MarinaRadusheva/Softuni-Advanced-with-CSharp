using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;
        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            this.students = new List<Student>();
        }
        public int Capacity { get; set; }
        public int Count
        {
            get { return this.students.Count; }
        }
        public string RegisterStudent(Student student)
        {
            if (this.Count < this.Capacity)
            {
                this.students.Add(student);
                return ($"Added student {student.FirstName} {student.LastName}");
            }
            else
            {
                return "No seats in the classroom";
            }
        }
        public string DismissStudent(string firstName, string lastName)
        {
            Student dismissedStudent = this.students.FirstOrDefault(x => (x.FirstName == firstName && x.LastName == lastName));
            if (dismissedStudent != null)
            {
                this.students.Remove(dismissedStudent);
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return "Student not found";
            }
        }
        public string GetSubjectInfo(string subject)
        {
            Student[] studentsBySubject = this.students.Where(x => x.Subject == subject).ToArray();
            StringBuilder sb = new StringBuilder();
            if (studentsBySubject.Length != 0)
            {
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");
                foreach (var student in studentsBySubject)
                {
                    sb.AppendLine($"{student.FirstName} {student.LastName}");
                }
                return sb.ToString().TrimEnd();
            }
            else
            {
                return "No students enrolled for the subject";
            }

        }
        public int GetStudentsCount()
        {
            return this.Count;
        }
        public Student GetStudent(string firstName, string lastName)
        {
            return this.students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }

    }
}
