using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public virtual int Age 
        { get
            {
                return this.age;
            }
            set
            {
                if (value>=0)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("Age cannot be less than 0");
                }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {this.Name}, Age: {this.Age}");
            return sb.ToString();
        }
    }
}
