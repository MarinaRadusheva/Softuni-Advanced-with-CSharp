using System;
using System.Collections.Generic;


namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] peopleInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            try
            {

            
            List<Person> people = new List<Person>();

            GeneratePeople(peopleInput, people);
            string[] productsInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<Product> products = new List<Product>();
            GenerateProducts(productsInput, products);

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "END")
                {
                    break;
                }

                string name = command[0];
                string product = command[1];
                foreach (var buyer in people)
                {
                    if (buyer.Name == name)
                    {
                        foreach (var thing in products)
                        {
                            if (thing.Name == product)
                            {
                                buyer.BuyProduct(thing);

                            }
                        }

                    }
                }
            }
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }

        }
        static void GeneratePeople(string[] peopleInput, List<Person> people)
        {
            foreach (var item in peopleInput)
            {
                string[] itemTokens = item.Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = itemTokens[0];
                double amount = double.Parse(itemTokens[1]);
                Person person = new Person(name, amount);
                people.Add(person);
            }
        }
        static void GenerateProducts(string[] productsInput, List<Product> products)
        {
            foreach (var item in productsInput)
            {
                string[] itemTokens = item.Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = itemTokens[0];
                double amount = double.Parse(itemTokens[1]);
                Product product = new Product(name, amount);
                products.Add(product);
            }
        }
    }
}
