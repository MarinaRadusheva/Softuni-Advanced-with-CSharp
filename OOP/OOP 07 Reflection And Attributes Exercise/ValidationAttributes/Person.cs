using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    public class Person
    {
        private string fullName;
        private int age;
        public Person(string fullName, int age)
        {
            this.FullName = fullName;
            this.Age = age;
        }
        [MyRequired]
        public string FullName { get; private set; }
        [MyRange(12, 90)]
        public int Age { get; private set; }
    }
}
