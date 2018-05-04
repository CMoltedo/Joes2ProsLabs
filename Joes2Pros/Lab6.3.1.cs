using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Grid
    {
        public struct Results
        {
            public int rows;
            public int columns;
            public char symbol;
        }


        public static Results Prompt()
        {
            Results masterResult = new Results();

            Console.Write("How many times should the character repeat?");
            masterResult.rows = int.Parse(Console.ReadLine());
            Console.Write("How many rows would you like?");
            masterResult.columns = int.Parse(Console.ReadLine());
            Console.WriteLine("Press the key you want to draw using...");
            masterResult.symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();
            
            return masterResult;
        }

        public static void Create(Results input)
        {
            


            for (int cols = 0; cols <= input.columns; cols++)
            {
                for (int i = 0; i <= input.rows; i++)
                {
                    Console.Write($"{input.symbol} ");
                }

                Console.WriteLine();
            }
                       

        }
    }
}
