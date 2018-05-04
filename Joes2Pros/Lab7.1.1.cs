using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class ArrayNumbers
    {
        public static void Show()
        {
            byte[] numbers = new byte[8];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;
            numbers[5] = 60;
            numbers[6] = 70;
            numbers[7] = 80;

            //// For Lab 7.1.1
            //for (byte number = 0; number < 8; number++)
            //{
            //    Console.Write($"{numbers[number]} ");
            //}

            //// For Lab 7.1.2
            //foreach (int number in numbers)
            //{
            //    Console.Write($"{number} ");
            //}

            // For Lab 7.1.3
            double sum = 0;
            double avg = 0;
            foreach (int number in numbers)
            {
                sum = sum + number;
                Console.Write($"{number} ");
            }
            avg = sum / numbers.Count();
            Console.WriteLine();
            Console.WriteLine($"Your sum is {sum}");
            Console.WriteLine($"Your average is {avg}");

        }
    }
}
