using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person first = new Person();
            Person second = new Person(5);
            Person third = new Person("Marina", 10);
        }
    }
}
