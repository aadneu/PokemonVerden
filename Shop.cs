﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke
{
    internal class Shop
    {
        public List<IItem> ItemsInShop = new List<IItem>();
        public Potion Healthpotion;
        public Pokeball Pokeball;

        public Shop()
        {
            Healthpotion = new Potion();
            Pokeball = new Pokeball();
            ItemsInShop.Add(Healthpotion);
            ItemsInShop.Add(Pokeball);
        }

        public void displayItems()
        {
            Console.WriteLine("Velcome to PokeShop, we can offer the following: ");
            for (int i = 0; i < ItemsInShop.Count; i++)
            {
                Console.Write($"{i}: "); ItemsInShop[i].ShowItem();
            }
        }



    }
}
