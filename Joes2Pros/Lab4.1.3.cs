using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Boxing
    {

        public static void ShowDate()
        {

            object obj = DateTime.Now;
            Console.WriteLine($"{(DateTime)obj}");
        }

    }
}
