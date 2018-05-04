using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class NumberToWord
    {

        public static void Prompt()
        {
            //NOTE this is Lab 5.1.1 and 5.1.2.
        
            string input;
            int inputInt;

            Console.WriteLine("Please enter an integer between 1 and 5.");
            input = Console.ReadLine();
            inputInt = int.Parse(input);
            if (inputInt == 1) Console.WriteLine("One");
            else if (inputInt == 2) Console.WriteLine("Two");
            else if (inputInt == 3) Console.WriteLine("Three");
            else if (inputInt == 4) Console.WriteLine("Four");
            else if (inputInt == 5) Console.WriteLine("Five");
            else Console.WriteLine("You dun fucked up");
            

        }

    }
}
