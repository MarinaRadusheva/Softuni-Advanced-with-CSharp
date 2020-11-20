using System;
using System.Collections.Generic;

namespace _07_SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> reg = new HashSet<string>();
            string guest = Console.ReadLine();
            while (guest!="PARTY")
            {
                if (char.IsDigit(guest[0]))
                {
                    vip.Add(guest);
                }
                else
                {
                    reg.Add(guest);
                }
                guest = Console.ReadLine();
            }
            guest = Console.ReadLine();
            while (guest!="END")
            {
                if (reg.Contains(guest))
                {
                    reg.Remove(guest);
                }
                if (vip.Contains(guest))
                {
                    vip.Remove(guest);
                }
                guest = Console.ReadLine();
            }
            int noshows = vip.Count + reg.Count;
            Console.WriteLine(noshows);
            foreach (var item in vip)
            {
                Console.WriteLine(item);
            }
            foreach (var item in reg)
            {
                Console.WriteLine(item);
            }
        }
    }
}
