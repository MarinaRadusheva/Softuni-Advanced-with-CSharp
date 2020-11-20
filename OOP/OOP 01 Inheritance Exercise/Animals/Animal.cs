using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal //: IEnumerable
    {
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            
        }
        //public Animal(string name, int age)
        //{
        //    this.Name = name;
        //    this.Age = age;
        //}
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        //public IEnumerator GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

        public abstract string ProduceSound();
    }
}
