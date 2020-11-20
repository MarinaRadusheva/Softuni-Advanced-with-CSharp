using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_VloggersClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Vlogger> vloggers = new Dictionary<string, Vlogger>();
            string input = Console.ReadLine();
            while (input != "Statistics")
            {
                string[] newInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input.Contains("joined"))
                {
                    string joiner = newInput[0];
                    if (!vloggers.ContainsKey(joiner))
                    {
                        Vlogger newVlogger = new Vlogger(newInput[0], new HashSet<string>(), new HashSet<string>());
                        vloggers.Add(joiner, newVlogger);
                    }
                }
                else
                {
                    string follower = newInput[0];
                    string followed = newInput[2];
                    if (follower!=followed)
                    {
                        if (vloggers.ContainsKey(follower)&&vloggers.ContainsKey(followed))
                        {
                            vloggers[followed].followers.Add(follower);
                            vloggers[follower].following.Add(followed);
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"The V-Logger has a total of { vloggers.Count} vloggers in its logs.");
            int maxFollowers = 0;
            int minFollowing = int.MaxValue;
            string bestVlogger = "";
            
            foreach (var item in vloggers)
            {
                if(item.Value.followers.Count>maxFollowers)
                {
                    maxFollowers = item.Value.followers.Count;
                    minFollowing = item.Value.following.Count;
                    bestVlogger = item.Key;
                }
                else if (item.Value.followers.Count==maxFollowers)
                {
                    if (minFollowing>item.Value.following.Count)
                    {
                        minFollowing = item.Value.following.Count;
                        bestVlogger = item.Key;
                    }
                }
            }
            Console.WriteLine($"1. {bestVlogger} : { maxFollowers} followers, { minFollowing} following");
            vloggers[bestVlogger].followers=vloggers[bestVlogger].followers.OrderBy(x => x).ToHashSet();
            foreach (var follower in vloggers[bestVlogger].followers)
            {
                Console.WriteLine("*  "+follower);
            }
            vloggers.Remove(bestVlogger);
            vloggers = vloggers.OrderByDescending(x => x.Value.followers.Count).ThenBy(x => x.Value.following.Count).ToDictionary(a => a.Key, b => b.Value);
            int num = 2;
            foreach (var vlog in vloggers)
            {
                Console.WriteLine($"{ num}. { vlog.Key} : { vlog.Value.followers.Count} followers, { vlog.Value.following.Count} following");
                num++;
            }
        }
        public class Vlogger
        {

            public Vlogger(string name, HashSet<string> followers, HashSet<string> following)
            {
                this.name = name;
                this.followers = followers;
                this.following = following;
            }
            public string name { get; set; }
            public HashSet<string> followers { get; set; }
            public HashSet<string> following { get; set; }
        }
    }
}