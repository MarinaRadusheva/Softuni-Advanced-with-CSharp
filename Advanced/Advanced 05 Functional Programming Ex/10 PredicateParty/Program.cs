using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _10_PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split().ToList();
            string input = Console.ReadLine();
            while (input!="Party!")
            {
                string[] inputArray = input.Split();
                guests = GuestListModifier(guests, inputArray, ConditionPredicate(inputArray));
                input = Console.ReadLine();
            }
            if (guests.Count!=0)
            {
                Console.WriteLine(string.Join(", ", guests) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            
            
        }
        static Predicate<string> ConditionPredicate(string[] input)
        {
            
            string action = input[1];
            switch (action)
            {
                case "StartsWith":
                    string startingString = input[2];
                    return x => x.Substring(0, startingString.Length) == startingString;
                // x=Pesho, eS = sho => index = 5-3=2 
                case "EndsWith":
                    string endingString = input[2];
                    return x => x.Substring(x.Length - endingString.Length) == endingString;
                case "Length":
                    int nameLength = int.Parse(input[2]);
                    return x => x.Length == nameLength;
                default:
                    return null;

            }
            
        }
        static List<string> GuestListModifier(List<string> guests, string[] input, Predicate<string> condition)
        {
            List<string> modified = new List<string>();
            string command = input[0];
            switch (command)
            {
                case "Remove":
                    foreach (var item in guests)
                    {
                        if (!ConditionPredicate(input)(item))
                        {
                            modified.Add(item);
                        }
                    }
                    return modified;
                case "Double":
                    foreach (var item in guests)
                    {
                        modified.Add(item);
                        if (ConditionPredicate(input)(item))
                        {
                            modified.Add(item);
                        }
                    }
                    return modified;
                default:
                    return null;
            }
        }
    }
}
