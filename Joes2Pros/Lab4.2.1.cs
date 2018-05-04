using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class AddTwoIntegers
    {
        public static void Request()
        {
            string input1;
            string input2;
            long result;

            Console.WriteLine("Please enter the first number:");
            input1 = Console.ReadLine();
            Console.WriteLine("Please enter the second number:");
            input2 = Console.ReadLine();

            result = Int64.Parse(input1) + Int64.Parse(input2);

            Console.WriteLine($"Sum of {input1} and {input2} is {result}!");

        }
    }
}
