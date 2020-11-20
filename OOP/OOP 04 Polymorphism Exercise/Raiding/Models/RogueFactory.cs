using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class RogueFactory : HeroCreator
    {
        private string name;
        private int power;
        public RogueFactory(string name)
        {
            this.name = name;
        }
        public override BaseHero CreateHero()
        {
            return new Rogue(name);
        }
    }
}
