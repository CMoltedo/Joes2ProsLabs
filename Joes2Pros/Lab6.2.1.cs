using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class NumbersToTen
    {
        public static void Prompt()
        {
            Console.Write("Input a number between 0 and 10:");
            int number = int.Parse(Console.ReadLine());
            number = number--;
            while(number <= 9)
            {
                number++;
                Console.WriteLine(number);
            }
        }
    }
}
