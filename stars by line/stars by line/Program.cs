using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stars_by_line
{
    class Program
    {
        static void Main(string[] args)
        {
            char stars = '*';

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(stars);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            

        }
    }
}
