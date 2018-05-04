using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class VacationDays
    {
        enum Day
        {
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7
        }

        public static void PromptForDaysOff()
        {
            string firstchoice;
            string secondchoice;

            Day firstDay;
            Day secondDay;

            Console.WriteLine("What is the first day you want off?");
            firstchoice = Console.ReadLine();
            Console.WriteLine("What is the second day you want off?");
            secondchoice = Console.ReadLine();

            firstDay = (Day)Enum.Parse(typeof(Day), firstchoice);
            secondDay = (Day)Enum.Parse(typeof(Day), secondchoice);

            Console.WriteLine($"Your choices of {firstDay}:{(int)firstDay} and {secondDay}:{(int)secondDay} are fine!");


        }
    }
}
