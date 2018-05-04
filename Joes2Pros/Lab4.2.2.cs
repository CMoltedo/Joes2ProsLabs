using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class CSharp
    {
        

        public static void Questionare()
        {
            int yearanswer;
            bool yesnoanswer;

            Console.WriteLine("In what year was C# 4.0 released? ");
            yearanswer = int.Parse(Console.ReadLine());
            Console.WriteLine("Is C# an object-oriented language? ");
            yesnoanswer = bool.Parse(Console.ReadLine());

            Console.WriteLine($"C# 4.0 was released in {yearanswer.ToString()}");
            Console.WriteLine($"C# is an object-oriented language: {yesnoanswer.ToString()}");

        }


    }
}
