using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class CoffeeShop
    {
        [Flags]
        enum Coffee
        {
            Latte = 1,
            Mocha = 2,
            CarmelLatte = 4,
            VanillaLatte = 8,
            WhiteMocha = 16
        }

        public static void ShowCoffeeChoices()
        {
            Coffee choices = (Coffee.Latte | Coffee.VanillaLatte | Coffee.WhiteMocha);

            Console.WriteLine(choices.ToString());

        }
    }
}
