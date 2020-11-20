using System;
using System.Collections.Generic;

namespace _07_VLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> vloggers = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input!="Statistics")
            {
                string[] newInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input.Contains("joined"))
                {
                    string joiner = newInput[0];
                    if (!vloggers.ContainsKey(joiner))
                    {
                        vloggers.Add(joiner, new List<string>());
                    }
                }
                else
                {
                    string follower = newInput[0];
                    string followed = newInput[newInput.Length - 1];
                    if (follower!=followed&&vloggers.ContainsKey(followed))
                    {
                        if (!vloggers[followed].Contains(follower))
                        {
                            vloggers[followed].Add(follower);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            int maxFollowers = -1;
            string bestVlogger = "";
            foreach (var vlogger in vloggers)
            {
                if (vlogger.Value.Count>maxFollowers)
                {
                    maxFollowers = vlogger.Value.Count;
                    bestVlogger = vlogger.Key;
                }
            }
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            Console.WriteLine($"1. { bestVlogger} : { maxFollowers} followers, { followings} following");
            //*  { follower1}
            //*  { follower2} … 
            //{ No}. { vlogger} : { followers}
            //followers, { followings}
            //following

        }
    }
}
