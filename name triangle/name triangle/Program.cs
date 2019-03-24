using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace name_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Your name");
            //string name = Console.ReadLine();

            //for (int i = 0; i < name.Length; i++)
            //{
            //    for (int j = 0; j < 1; j++)
            //    {
            //        Console.WriteLine(name);
            //    }
            //}

            int n, N1, N2;
            int S1, S2;

            Console.Write("Introduce un número: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce la anchura: ");
            N1 = Convert.ToInt32(Console.ReadLine());
            N2 = N1;

            for (S1 = 0; S1 < N2; S1++)
            {
                for (S2 = 0; S2 < N1; S2++)
                    Console.Write(n);
                Console.WriteLine();
                N1--;
            }

        }

    }
}

