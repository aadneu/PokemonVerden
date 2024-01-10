

namespace Poke
{
    public class Potion : IItem
    {
        public void UseItem()
        {
            Console.WriteLine("*Uses Healthpotion*");
        }

        public void ShowItem()
        {
            Console.WriteLine("Healthpotion");
        }
    }
}
