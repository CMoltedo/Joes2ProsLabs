using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class EnumCasting
    {
        enum Status
        {
            Unknown = 0,
            Active = 1,
            Inactive = 2
        }

        public static void Show()
        {
            Status statusUnknown = Status.Unknown;
            Status statusActive = Status.Active;

            Console.WriteLine($"{statusUnknown}:{(int)statusUnknown}");
            Console.WriteLine($"{statusActive}:{(int)statusActive}");


        }
    }
}
