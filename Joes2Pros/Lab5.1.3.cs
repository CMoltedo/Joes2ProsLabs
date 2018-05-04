using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class MyCalculator
    {
        public static void Prompt()
        {
            char mathOperator;
            int firstNum;
            int secondNum;
            int result = 0;

            Console.WriteLine("Please input first number:");
            firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input second number:");
            secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please press operator key (+, -, /, or *): ");
            mathOperator = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if(mathOperator == '+')
            {
                result = firstNum + secondNum;
            }
            if (mathOperator == '-')
            {
                result = firstNum - secondNum;
            }
            if (mathOperator == '/')
            {
                result = firstNum / secondNum;
            }
            if (mathOperator == '*')
            {
                result = firstNum * secondNum;
            }

            Console.WriteLine($"Your result is {result.ToString()}");

        }
    }
}
