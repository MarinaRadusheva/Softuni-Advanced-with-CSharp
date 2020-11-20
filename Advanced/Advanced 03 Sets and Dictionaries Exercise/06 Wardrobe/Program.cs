using System;
using System.Collections.Generic;

namespace _06_Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                //"{color} -> {item1},{item2},{item3}…
                string[] input= Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string colour = input[0];
                string[] nextItems = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe.Add(colour, new Dictionary<string, int>());
                }

                for (int j = 0; j < nextItems.Length; j++)
                {
                    if (wardrobe[colour].ContainsKey(nextItems[j]))
                    {
                        wardrobe[colour][nextItems[j]]++;
                    }
                    else
                    {
                        wardrobe[colour].Add(nextItems[j], 1);
                    }
                }
            }
            string[] wanted = Console.ReadLine().Split();
            string wantedColour = wanted[0];
            string wantedItem = wanted[1];
            foreach (var colour in wardrobe)
            {
                //Blue clothes:
                //*dress - 1(found!)


                Console.WriteLine($"{colour.Key} clothes:");
                foreach (var piece in colour.Value)
                {
                    if (wantedColour==colour.Key&&wantedItem==piece.Key)
                    {
                        Console.WriteLine($"* {piece.Key} - {piece.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {piece.Key} - {piece.Value}");
                    }
                }
                
            }
        }
    }
}

