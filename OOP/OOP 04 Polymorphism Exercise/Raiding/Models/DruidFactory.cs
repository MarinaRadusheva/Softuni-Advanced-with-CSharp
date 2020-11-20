using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class DruidFactory : HeroCreator
    {
        private string name;
        private int power;
        public DruidFactory(string name)
        {
            this.name = name;
        }
        public override BaseHero CreateHero()
        {
            return new Druid(name);
        }
    }
}
