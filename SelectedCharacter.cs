using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml;

namespace Poke
{
    internal class SelectedCharacter
    {
        public Trainer Ash;
        public bool RunGame { get; set; }

        public SelectedCharacter()
        {
            Ash = new Trainer(new Pokemon("Pikachu", 13, 25, 500));
            RunGame = true;
        }

        public void LeaveHouse()
        {
            Console.WriteLine("You wake up at home in Pallet Town, its a new beautiful day...");
            Console.WriteLine("What do you want to do?");
            ChooseWhatToDo();
        }

        void ListChoice(int number, string choice)
        {
            Console.WriteLine($"{number}: {choice}");
        }

        void ChooseWhatToDo()
        {
            ListChoice(1, "Go fight at the gym!");
            ListChoice(2, "Search the grass for new pokemons!");
            ListChoice(3, "Buy something at the Shop!");
            ListChoice(4, "Heal the one and only.");
            ListChoice(5, "Go to sleep!");
            ListChoice(6, "Exit game");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    EnterPokegym();
                    break;
                case "2":
                    SearchForPokemon();
                    break;
                case "3":
                    BuyPotionOrPokeball();
                    break;
                case "4":
                    HealPokemon(Ash.Pokedex[0]);
                    break;
                case "5":
                    Sleep();
                    break;
                case "6":
                    RunGame = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(500);
                    break;
            }
        }

       

        public void BuyPotionOrPokeball()
        {
            var shop = new Shop();
            shop.displayItems();
            Console.WriteLine("What do you want to buy? (0) (1)");
            if (int.TryParse(Console.ReadLine(), out int input) && (input == 0 || input == 1))
            {
                Ash.Items.Add(shop.ItemsInShop[input]);
                Console.Write("Thanks for buying ");
                shop.ItemsInShop[input].ShowItem();
                Thread.Sleep(1000);
            }
        }

        public void Sleep()
        {
            Console.WriteLine("*Goes to sleep*");
            Thread.Sleep(3000);
            Console.WriteLine("You awake feeling fully refreshed");
            Thread.Sleep(1000);
        }

        public void SearchForPokemon()
        {
            var grass = new Grass(1);
            Console.WriteLine("*You start looking through the tall grass... *");
            Thread.Sleep(2000);
            Console.WriteLine($"A wild {grass.WildPokemons[0].Name} has appeared");
            Console.WriteLine("Do you want to catch it? (y) (n)");
            if (Console.ReadLine() == "y")
            {
                CatchPokemon(grass.WildPokemons[0]);
            } else {
                Console.WriteLine("Okay then, move on...");
                Thread.Sleep(1000);
            }
        }

        public void EnterPokegym()
        {
            Console.WriteLine("*Welcome to the gym!*");
            var gym = new Gym();
            Thread.Sleep(1000);
            Console.WriteLine($"Do you want to fight {gym.Trainer}? (y) (n)");
            if (Console.ReadLine() == "y")
            {
                AttackTrainer(gym);
            }
            else
            {
                Console.WriteLine("See you later Aligator");
                Thread.Sleep(1000);
            }
            
            Console.WriteLine("*Leaves gym*");
            Thread.Sleep(1000);
        }

        public void AttackTrainer(Gym gym)
        {
            var rand = new Random();
            int opponentPokemons = gym.Trainer.Pokedex.Count;
            
            Pokemon opponent = gym.Trainer.Pokedex[rand.Next(0, opponentPokemons)];
            Pokemon myPokemon = Ash.Pokedex[0];
            myPokemon.PokemonFight(myPokemon,opponent);
        }

        void BuyItem(IItem item)
        {
            Ash.Items.Add(item);
        }
       public void CatchPokemon(Pokemon pokemon)
        {
            for (int i = Ash.Items.Count - 1; i >= 0; i--)
            {
                if (Ash.Items[i] is Pokeball)
                {
                    ((Pokeball)Ash.Items[i]).UseItem();
                    Thread.Sleep(1000);
                }
            }

            if (!Ash.Items.OfType<Pokeball>().Any())
            {
                Console.WriteLine("You need to buy pokeballs...");
                Thread.Sleep(1000);
                return;
            }

            Console.WriteLine($"Congrats, you caught {pokemon.Name}.");
            Console.WriteLine($"*Added {pokemon.Name} to your pokedex!*");
            Ash.Items.RemoveAll(item => item is Pokeball);
            Ash.Pokedex.Add(pokemon);
            Thread.Sleep(1000);
        }

        public void HealPokemon(Pokemon pokemon)
        {
            for (int i = Ash.Items.Count - 1; i >= 0; i--)
            {
                if (Ash.Items[i] is Potion)
                {
                    Ash.Items[i].UseItem();
                    Thread.Sleep(1000);
                }
            }

            if (!Ash.Items.OfType<Potion>().Any())
            {
                Console.WriteLine("You need to buy potions if you want heal...");
                Thread.Sleep(1000);
                return;
            }
            Console.WriteLine($"{pokemon.Name} is back to full health!");
            pokemon.SetHealth(pokemon.MaxHealth);
            Thread.Sleep(1000);
        }


        public void ShowPokedex()
        {
            Console.WriteLine("This is your pokemons: ");
            for (int i = 0; i < Ash.Pokedex.Count; i++)
            {
                Console.WriteLine($"{i}, {Ash.Pokedex[i].Name}, Lvl: {Ash.Pokedex[i].Level}, HP: {Ash.Pokedex[i].Health}, dmg: {Ash.Pokedex[i].Damage}");
            }
        }
    }
}
