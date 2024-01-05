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
        public List<Pokemon> Pokedex = new List<Pokemon>() { new Pokemon() };
        public List<IItem> Items =  new List<IItem>();

        void BuyItem()
        {

        }

        void CatchPokemon()
        {
            bool containsPokeBall()
            {
                return Items.Any(x => x is Pokeball);
            }

            if (containsPokeBall())
            {
                foreach (Pokeball item in Items)
                {
                    item.UseItem();
                }
            }
        }
    }
}
