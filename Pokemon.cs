using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Poke
{
    internal class Pokemon
    {
        public string Name { get; set; }
        protected int Level { get; set; }
        protected int Damage { get; set; }
        protected int Health { get; set; }

        protected Random rand = new Random();

        
       

        public Pokemon()
        {
            Name = PokemonNames[rand.Next(0, PokemonNames.Count)];
            Level = rand.Next(1, 21);
            Damage = rand.Next(5, 21);
            Health = rand.Next(70, 251);
        }

        public Pokemon(int amount, List<Pokemon> list)
        {
           
        }

        
        public int Attack()
        {
            return Damage;
        }

        public int HP()
        {
            return Health;
        }


        protected List<string> PokemonNames = new List<string>()
        {
            "Bulbasaur",
            "Ivysaur",
            "Venusaur",
            "Charmander",
            "Charmeleon",
            "Charizard",
            "Squirtle",
            "Wartortle",
            "Blastoise",
            "Caterpie",
            "Metapod",
            "Butterfree",
            "Pikachu",
            "Raichu",
            "Jigglypuff",
            "Wigglytuff",
            "Meowth",
            "Persian",
            "Psyduck",
            "Golduck",
            "Mankey",
            "Primeape",
            "Growlithe",
            "Arcanine",
            "Poliwag",
            "Poliwhirl",
            "Poliwrath",
            
        };
    }
}
