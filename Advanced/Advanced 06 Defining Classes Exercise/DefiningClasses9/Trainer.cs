using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        private string name;
        private int badges=0;
        private List<Pokemon> pokemons;
        public Trainer(string name, List<Pokemon> pokemons)
        {
            this.Nmae = name;
            this.Pokemons = pokemons;
        }
        public string Nmae { get;}
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    }
}
