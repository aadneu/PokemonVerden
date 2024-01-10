using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke
{
    internal class Grass
    {
        
        public List<Pokemon> WildPokemons;
        
        public Grass(int amountOfPokemons)
        {
            WildPokemons = new List<Pokemon>();
            for (int i = 0; i < amountOfPokemons; i++)
            {
                WildPokemons.Add(new Pokemon());
            }
        }
    }
}
