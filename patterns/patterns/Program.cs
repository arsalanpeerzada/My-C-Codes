using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //for (int x = -1; x <= 8; x++)
            //{
            //    int y = (x - 4) * (x - 4);
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            int x, y, j;
            for (x = 0; x <= 8; x++)
            {
                y = (x - 4) * (x - 4);

                for (j = 0; j < y; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
