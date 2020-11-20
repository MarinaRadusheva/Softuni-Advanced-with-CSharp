using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            List<Animal> allAnimals = new List<Animal>();
            while (type!="Beast!")
            {
                Animal animal;
                string[] animalTokens = Console.ReadLine().Split();
                if (animalTokens.Length<2)
                {
                    throw new ArgumentException("Invalid input!");
                }
                string name = animalTokens[0];
                int age = int.Parse(animalTokens[1]);
                if (age<0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                string gender =animalTokens[2];
                switch (type)
                {
                    case "Cat":
                        animal = new Cat(name, age, gender);
                        allAnimals.Add(animal);
                        break;
                    case "Dog":
                        animal = new Dog(name, age, gender);
                        allAnimals.Add(animal);
                        break;
                    case "Frog":
                        animal = new Frog(name, age, gender);
                        allAnimals.Add(animal);
                        break;
                    case "Kitten":
                        animal = new Kitten(name, age);
                        allAnimals.Add(animal);
                        break;
                    case "Tomcat":
                        animal = new Tomcat(name, age);
                        allAnimals.Add(animal);
                        break;
                    default:
                        throw new ArgumentException("Invalid input!");

                }
                
                type = Console.ReadLine();
            }
            foreach (var item in allAnimals)
            {
                Console.WriteLine(item.GetType().Name);
                Console.WriteLine($"{item.Name} {item.Age} {item.Gender}");
                Console.WriteLine(item.ProduceSound());
            }
        }
    }
}
