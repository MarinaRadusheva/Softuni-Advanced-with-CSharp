using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models;
namespace WildFarm.Core
{
    public class Engine
    {
        public void Run()
        {
            List<Animal> animals = new List<Animal>();
            string animalInput;
            while ((animalInput=Console.ReadLine())!="End")
            {
                //Felines - "{Type} {Name} {Weight} {LivingRegion} {Breed}";
                //Birds - "{Type} {Name} {Weight} {WingSize}";
                //Mice and Dogs - "{Type} {Name} {Weight} {LivingRegion}";

                string[] animalTokens = animalInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = animalTokens[0];
                string name = animalTokens[1];
                double weight = double.Parse(animalTokens[2]);
                Animal newAnimal = null;
                newAnimal = CreateAnimal(animals, animalTokens, type, name, weight, newAnimal);
                if (newAnimal != null)
                {
                    Console.WriteLine(newAnimal.ProduceSound());
                    Food food = null;
                    food = CreateFood(food);
                    try
                    {
                        newAnimal.Eat(food);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static Food CreateFood(Food food)
        {
            string[] foodInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string typeOfFood = foodInput[0];
            int foodQuantity = int.Parse(foodInput[1]);
            switch (typeOfFood)
            {
                case "Vegetable":
                    food = new Vegetable(foodQuantity);
                    break;
                case "Meat":
                    food = new Meat(foodQuantity);
                    break;
                case "Fruit":
                    food = new Fruit(foodQuantity);
                    break;
                case "Seeds":
                    food = new Seeds(foodQuantity);
                    break;
            }

            return food;
        }

        private static Animal CreateAnimal(List<Animal> animals, string[] animalTokens, string type, string name, double weight, Animal newAnimal)
        {
            switch (type)
            {
                case "Hen":
                    newAnimal = new Hen(name, weight, double.Parse(animalTokens[3]));
                    animals.Add(newAnimal);
                    break;
                case "Owl":
                    newAnimal = new Owl(name, weight, double.Parse(animalTokens[3]));
                    animals.Add(newAnimal);
                    break;
                case "Dog":
                    newAnimal = new Dog(name, weight, animalTokens[3]);
                    animals.Add(newAnimal);
                    break;
                case "Mouse":
                    newAnimal = new Mouse(name, weight, animalTokens[3]);
                    animals.Add(newAnimal);
                    break;
                case "Cat":
                    newAnimal = new Cat(name, weight, animalTokens[3], animalTokens[4]);
                    animals.Add(newAnimal);
                    break;
                case "Tiger":
                    newAnimal = new Tiger(name, weight, animalTokens[3], animalTokens[4]);
                    animals.Add(newAnimal);
                    break;
                default:
                    break;
            }

            return newAnimal;
        }
    }
}
