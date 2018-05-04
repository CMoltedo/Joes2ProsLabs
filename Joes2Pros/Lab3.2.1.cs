using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    
    class WorkingDays
    {
        enum Weekdays
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5
        }
        public static void Show()
        {
            var Monday = Weekdays.Monday.ToString();
            var Tuesday = Weekdays.Tuesday.ToString();
            var Wednesday = Weekdays.Wednesday.ToString();
            var Thursday = Weekdays.Thursday.ToString();
            var Friday = Weekdays.Friday.ToString();

            Console.WriteLine(Monday);
            Console.WriteLine(Tuesday);
            Console.WriteLine(Wednesday);
            Console.WriteLine(Thursday);
            Console.WriteLine(Friday);

        }
    }
}
