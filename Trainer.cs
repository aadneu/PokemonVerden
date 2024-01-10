using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Poke
{
    internal class Trainer
    {
        public List<Pokemon> Pokedex;
        public List<IItem> Items;

        public Trainer()
        {
            Pokedex = new List<Pokemon>() { new Pokemon() };
            Items = new List<IItem>();
        }
        public Trainer(int numOFPokemons)
        {
            Pokedex = new List<Pokemon>();

            for (int i = 0; i < numOFPokemons; i++)
            {
                Pokedex.Add(new Pokemon());
            }
            Items = new List<IItem>();
        }

        public Trainer(Pokemon pokemon)
        {
            Pokedex = new List<Pokemon>();
            Pokedex.Add(pokemon);
            Items = new List<IItem>();
        }

        

        
    }
}
