using System;
using System.Collections.Generic;

namespace _04_Continents
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] nextLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = nextLine[0];
                string country = nextLine[1];
                string city = nextLine[2];
                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                    continents[continent].Add(country, new List<string> { city });
                }
                else
                {
                    if (!continents[continent].ContainsKey(country))
                    {
                        continents[continent].Add(country, new List<string> { city });
                    }
                    else
                    {
                        continents[continent][country].Add(city);
                    }
                }
            }
            foreach (var continent in continents)
            {
                Console.WriteLine(continent.Key+":");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
