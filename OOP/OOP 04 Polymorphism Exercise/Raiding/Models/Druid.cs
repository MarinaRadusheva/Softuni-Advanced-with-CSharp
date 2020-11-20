using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        private const int POWER = 80;
        private string name;
        private int power = POWER;
        public Druid(string name)
        {
            this.Name = name;
        }
        public override string Name { get => this.name; set => this.name = value; }
        public override int Power { get => this.power; set => this.power = value; }

        public override string CastAbility()
        {
            return ($"{nameof(Druid)} - {this.Name} healed for {this.Power}");
        }
    }
}
