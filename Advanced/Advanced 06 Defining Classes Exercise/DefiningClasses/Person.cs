﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {

        }
        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }
        public string Name 
        {
            get
            { return name; }
            set
            { name = value; }

        }
        public int Age 
        { 
            get
            { return age; }
            set
            { age = value; }
        }
    }
}
