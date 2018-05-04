using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class NullableTypes
    {
        public static void Show()
        {
            DateTime date;
            DateTime? dateNullable;

            dateNullable = DateTime.Now;
            date = (DateTime)dateNullable;

            Console.WriteLine(date);
            Console.WriteLine(dateNullable);

        }
    }
}
