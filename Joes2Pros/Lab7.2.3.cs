using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class SortedWords
    {
        public static void Show()
        {
            string[] words = { "Rod", "Pen", "Fruit", "Bed", "Ape" };

            Array.Sort(words);

            foreach(string word in words)
            {
                Console.WriteLine(word);
            }

        }
    }
}
