using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        public Person(string first, string last, int age, decimal salary)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Age = age;
            this.Salary = salary;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public decimal Salary { get; set; }
        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age<=30)
            {
                this.Salary += (this.Salary * percentage / 100)/2;
            }
            else
            {
                this.Salary += this.Salary * percentage / 100;
            }
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";

        }
    }
}
