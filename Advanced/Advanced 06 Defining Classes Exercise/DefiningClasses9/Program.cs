using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace DefiningClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            string newEntry = Console.ReadLine();
            while (newEntry!="Tournament")
            {
                //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}
                string[] newEntryTokens = newEntry.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = newEntryTokens[0];
                string pokemonName = newEntryTokens[1];
                string pokemonElement = newEntryTokens[2];
                int pokemonHealth = int.Parse(newEntryTokens[3]);
                if (trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName].Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                }
                else
                {
                    trainers.Add(trainerName, new Trainer(trainerName, new List<Pokemon>() { new Pokemon(pokemonName, pokemonElement, pokemonHealth) }));
                }
                newEntry = Console.ReadLine();
            }
            string command = Console.ReadLine();
            while (command!="End")
            {
                trainers = ModifyPokemons(trainers, command);
                command = Console.ReadLine();
            }
            foreach (var item in trainers.OrderByDescending(x => x.Value.Badges).ToDictionary(a => a.Key, b => b.Value))
            {
                Console.WriteLine($"{item.Key} {item.Value.Badges} {item.Value.Pokemons.Count}");
            }
        }

        public static Dictionary<String, Trainer> ModifyPokemons(Dictionary<string, Trainer> allTrainers, string command)
        {
            Dictionary<string, Trainer> modifiedTrainers = allTrainers;
            
            foreach (var trainer in allTrainers)
            {
                bool hasIt = false;
                foreach (var pokemon in trainer.Value.Pokemons)
                {
                    if (pokemon.Element==command)
                    {
                        hasIt = true;
                        break;
                    }
                }
                if (hasIt)
                {
                    modifiedTrainers[trainer.Key].Badges++;
                }
                else
                {              
                    modifiedTrainers[trainer.Key].Pokemons = modifiedTrainers[trainer.Key].Pokemons.Where(x => (x.Health-=10)> 0).ToList<Pokemon>();
                }
            }
            return modifiedTrainers;
        }
    }
}
