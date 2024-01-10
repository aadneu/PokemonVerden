using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke
{
    internal class World
    {
       public SelectedCharacter Character { get; set; }
       

       public World()
       {
           Character = new SelectedCharacter();
           
       }

       public void Run()
       {
           
           while (Character.RunGame)
           { 
              Console.WriteLine("***Welcome to the world of Pokemon!***");
              Character.LeaveHouse();
              Console.Clear();
           }

           Console.WriteLine("Thanks for playing!");
       }

    }
}
