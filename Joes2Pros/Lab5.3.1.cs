using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Drinks
    {
        public static void Prompt()
        {
            int choice;
            string thanks = "Thanks for choosing ";
            Console.WriteLine("Please choose a drink order from 1-5");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine(thanks + "Apple Juice");
                    break;
                case 2:
                    Console.WriteLine(thanks + "Orange Juice");
                    break;
                case 3:
                    Console.WriteLine(thanks + "Wine");
                    break;
                case 4:
                    Console.WriteLine(thanks + "Soda");
                    break;
                case 5:
                    Console.WriteLine(thanks + "Beer");
                    break;
                // This part is for Lab 5.3.2
                default: 
                    Console.WriteLine("HOLY CRAP WHYYY");
                    break;
            }

        }
    }
}
