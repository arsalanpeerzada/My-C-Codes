using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arrays_even
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of array You want to input");
            int input = Convert.ToInt32(Console.ReadLine());
            int []data =new int [input];

            for (int i = 0; i < input; i++)
            {
                Console.Write("Input Number:    ");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("      EVEN ");
            for (int i = 0; i < input; i++)
            {
                
                if (data[i]%2==0)
                {
                    Console.WriteLine(+data[i]);
                }
                
            }
        }
    }
}
