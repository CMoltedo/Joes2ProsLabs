using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class NumberGrid
    {
        public static void Show()
        {
            int[,] grid;
            grid = new int[5, 5];
            
            //{
            //    {0,0,0,0,0},
            //    {1,1,1,1,1},
            //    {2,2,2,2,2},
            //    {3,3,3,3,3},
            //    {4,4,4,4,4}
            //};

            for(int rows = 0; rows < 5; rows++)
            {
                for(int cols = 0; cols < 5; cols++)
                {
                    grid[rows,cols] = rows;

                }
            };

            for(int ri = 0; ri < grid.GetLength(0);ri++)
            {
                for(int ci = 0;ci< grid.GetLength(1); ci++)
                {
                    Console.Write($"{grid[ri,ci]} ");
                }

                Console.WriteLine();
            };

        }
    }
}
