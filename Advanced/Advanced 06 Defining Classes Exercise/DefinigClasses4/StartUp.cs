using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DefinigClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] nextPerson= Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                people.Add(new Person(nextPerson[0], int.Parse(nextPerson[1])));
            }
            
            people = people.Where(x => x.Age > 30).OrderBy(x=>x.Name).ToList();
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
