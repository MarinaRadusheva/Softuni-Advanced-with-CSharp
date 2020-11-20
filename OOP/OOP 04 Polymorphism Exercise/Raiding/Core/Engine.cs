using System;
using System.Collections.Generic;
using System.Text;
using Raiding.Models;
namespace Raiding.Core
{
    public class Engine
    {
        public void Run()
        {
            int heroCount = int.Parse(Console.ReadLine());
            List<BaseHero> heroes = new List<BaseHero>();
            while(heroes.Count<heroCount)
            {
                AddHeroes(heroes);
            }
            int bossPower = int.Parse(Console.ReadLine());
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
                bossPower -= hero.Power;
            }
            if (bossPower<=0)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        private static void AddHeroes(List<BaseHero> heroes)
        {
            HeroCreator newHero = null;
            string name = Console.ReadLine();
            string type = Console.ReadLine();
            switch (type)
            {
                case "Druid":
                    newHero = new DruidFactory(name);
                    break;
                case "Paladin":
                    newHero = new PaladinFactory(name);
                    break;
                case "Rogue":
                    newHero = new RogueFactory(name);
                    break;
                case "Warrior":
                    newHero = new WarriorFactory(name);
                    break;
                default:
                    Console.WriteLine("Invalid hero!");
                    break;
            }
            if (newHero != null)
            {
                heroes.Add(newHero.CreateHero());
            }
        }
    }
}
