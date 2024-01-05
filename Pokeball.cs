using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke
{
    public class Pokeball : IItem
    {
        public void UseItem()
        {
            Console.WriteLine("*Throws Pokeball...*");

        }
    }
}
