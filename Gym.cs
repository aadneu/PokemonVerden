using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke
{
    internal class Gym
    {
        public Trainer Trainer;
        protected Random rand = new Random();
        public Gym()
        {
            Trainer = new Trainer(rand.Next(5));
        }
    }
}
