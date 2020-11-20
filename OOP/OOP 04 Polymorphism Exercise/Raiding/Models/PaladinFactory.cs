using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class PaladinFactory : HeroCreator
    {
        private string name;
        private int power;
        public PaladinFactory(string name)
        {
            this.name = name;
        }
        public override BaseHero CreateHero()
        {
            return new Paladin(name);
        }
    }
}
