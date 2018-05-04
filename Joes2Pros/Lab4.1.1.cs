using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Numbers
    {
        public static void Show()
        {
            int integer1 = 100;
            int integer2 = 200;
            int integer3 = 257;
            
            byte byte1 = (byte)integer1;
            byte byte2 = (byte)integer2;
            byte byte3 = (byte)integer3;

            Console.WriteLine($"Integer value: {integer1} Byte value: {byte1}.");
            Console.WriteLine($"Integer value: {integer2} Byte value: {byte2}.");
            Console.WriteLine($"Integer value: {integer3} Byte value: {byte3}.");

        }
        


    }
}
