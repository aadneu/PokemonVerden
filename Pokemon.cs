using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Poke
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }

        protected Random rand = new Random();


        public void SetHealth(int health)
        {
            Health = health;
        }
       public Pokemon()
        {
            Name = PokemonNames[rand.Next(0, PokemonNames.Count)];
            Level = rand.Next(1, 21);
            Damage = rand.Next(5, 21);
            Health = rand.Next(70, 251);
            MaxHealth = Health;
        }

       public Pokemon(string name, int level, int damage, int health)
       {
           Name = name;
           Level = level;
           Damage = damage;
           Health = health;
       }

       public void PokemonFight(Pokemon myPokemon, Pokemon opponent)
       {
           bool fightMode = true;
           while (fightMode)
           {
               Attack(myPokemon, opponent);
               AttackTxt(myPokemon, opponent);
               Thread.Sleep(500);
               Attack(opponent, myPokemon);
               AttackTxt(opponent, myPokemon);
               Thread.Sleep(500);
               if (opponent.Health <= 0)
               {
                   Console.WriteLine("You have defeated the enemy!");
                   break;
               }
               if (myPokemon.Health <= 0)
               {
                   Console.WriteLine("You lost the fight.");
                   break;
               }
           }
       }

       void AttackTxt(Pokemon attacker, Pokemon defender)
       {
           Console.WriteLine($"{defender.Name} got hit by {attacker.Name}, he has {defender.Health} health left.");
       }
        
        public void Attack(Pokemon attacker, Pokemon defender)
        {
            defender.Health -= attacker.Damage;
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
