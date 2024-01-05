using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke
{
    public class Potion : IItem
    {
        public void UseItem()
        {
            Console.WriteLine("*Uses Healthpotion*");
        }
    }
}
