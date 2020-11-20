using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class WarriorFactory :HeroCreator
    {
        private string name;
        private int power;
        public WarriorFactory(string name)
        {
            this.name = name;
        }
        public override BaseHero CreateHero()
        {
            return new Warrior(name);
        }
    }
}
