using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for pattern");
            int lines = Convert.ToInt32(Console.ReadLine());
            int spaces = lines-1;
            int number = spaces-2;
            int reverse = lines - spaces;
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");                
                }
                spaces--;

                for (int k = 1; k < number; k++)
                {
                    Console.Write(k);
                }
                number++;
                for (int k = 1; k < reverse; k++)
                {
                    Console.Write(k);
                }
                reverse++;
                Console.WriteLine();
            }
        }
    }
}
