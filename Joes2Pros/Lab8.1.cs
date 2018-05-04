using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class HelloMethod
    {
        public static void Show()
        {
            Console.WriteLine("Hello there!");
        }
    }

    class SimpleCalculator
    {
        public static double Add(double x, double y)
        {
            double result = x + y;
            return result;
        }
        public static double Subtract(double x, double y)
        {
            double result = x - y;
            return result;
        }
        public static double Multiply(double x, double y)
        {
            double result = x * y;
            return result;
        }
        public static double Divide(double x, double y)
        {
            double result = x / y;
            return result;
        }

        public static void Test()
        {
            double a = 500;
            double b = 100;
            Console.WriteLine($"{a}+{b} = {SimpleCalculator.Add(a, b)}!");
            Console.WriteLine($"{a}-{b} = {SimpleCalculator.Subtract(a, b)}!");
            Console.WriteLine($"{a}*{b} = {SimpleCalculator.Multiply(a, b)}!");
            Console.WriteLine($"{a}/{b} = {SimpleCalculator.Divide(a, b)}!");
        }
    }

    class Adder
    {
        
        public static int Add(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }
        public static int Add(int[] numbers)
        {
            int result = 0;

            foreach(int number in numbers)
            {
                result = result + number;
            }

            return result;
        }

        public static void Test()
        {
            int number1 = 500;
            int number2 = 700;
            int[] numbers = { 100, 200, 300, 400 };
            Console.WriteLine(Adder.Add(number1, number2));
            Console.WriteLine(Adder.Add(numbers));
        }
    }

}
