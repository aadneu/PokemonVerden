using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke
{
    internal class World
    {
        public Shop PokeShop;

        public List<Pokemon> WildPokemons = new List<Pokemon>();

      
        public World(int amountOfPokemons)
        {
            PokeShop = new Shop();

            for (int i = 0; i < amountOfPokemons; i++)
            {
                WildPokemons.Add(new Pokemon());
            }
        }
    }
}
