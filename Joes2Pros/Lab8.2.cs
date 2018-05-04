using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Fullname
    {
        public static void CreateFullname(string firstName,string lastName,out string fullName)
        {
            fullName = firstName + " " + lastName;
        }

        public static void CreateFullnameTest()
        {
            string fullName;
            Fullname.CreateFullname("John", "Doe", out fullName);
            Console.WriteLine(fullName);
        }
        
    }

    class NumberSwap
    {
        public static void Swap(ref int X, ref int Y)
        {
            int heldx = X;
            X = Y;
            Y = heldx;
        }

        public static void SwapTest()
        {
            int X = 10;
            int Y = 20;
            Console.WriteLine($"X={X} and Y={Y}");
            NumberSwap.Swap(ref X, ref Y);
            Console.WriteLine($"X={X} and Y={Y}");
        }
    }
}
