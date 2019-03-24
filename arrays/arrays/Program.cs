using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] start = new int[5];

            for (int i = 0; i <start.Length; i++)
            {
                Console.Write("Number {0} = ",i+1);
                start[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            for (int i = 4; i >= 0; i--)
            {
                Console.Write("Arraged ={0}  ,",start[i]);
            }
        }
    }
}
