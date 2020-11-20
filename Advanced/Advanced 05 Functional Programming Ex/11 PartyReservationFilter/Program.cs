using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace _11_PartyReservationFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split().ToList();
            string input = Console.ReadLine();
            List<string> filters = new List<string>();
            while (input != "Print")
            {

                if (input.Contains("Add"))
                {
                    string substr = input.Substring(11);
                    filters.Add(substr);
                }
                else
                {
                    string filterToRemove = input.Substring(14);
                    filters.Remove(filterToRemove);
                }
                input = Console.ReadLine();
            }
            List<Predicate<string>> predicates = new List<Predicate<string>>();
            GetConditions(filters, predicates);
            foreach (var filter in predicates)
            {
                for (int i = 0; i < guests.Count; i++)
                {
                    if (filter(guests[i]))
                    {
                        guests.Remove(guests[i]);
                        i--;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", guests));
        }

        static void GetConditions(List<string> filters, List<Predicate<string>> predicates)
        {
            foreach (var item in filters)
            {
                string[] tokens = item.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                if (command == "Starts with")
                {
                    string starter = tokens[1];
                    predicates.Add(x => x.Substring(0, starter.Length) == starter);
                }
                else if (command == "Ends with")
                {
                    string end = tokens[1];
                    predicates.Add(x => x.Substring(x.Length-end.Length) == end);
                }
                else if (command == "Length")
                {
                    int len = int.Parse(tokens[1]);
                    predicates.Add(x => x.Length == len);
                }
                else
                {
                    string strToContain = tokens[1];
                    predicates.Add(x => x.Contains(strToContain));
                }
            }
        }
    }
}
