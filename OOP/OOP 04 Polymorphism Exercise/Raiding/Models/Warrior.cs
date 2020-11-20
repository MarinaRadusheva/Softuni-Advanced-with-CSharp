using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Warrior : BaseHero
    {
        private const int POWER = 100;
        private string name;
        private int power=POWER;
        public Warrior(string name)
        {
            this.Name = name;
        }
        public override string Name { get => this.name; set => this.name = value; }
        public override int Power { get => this.power; set => this.power = value; }

        public override string CastAbility()
        {
            return ($"{nameof(Warrior)} - {this.Name} hit for {this.Power} damage");
        }
    }
}
