using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter number how many data items you want to enter :    ");
            //int data = Convert.ToInt32(Console.ReadLine());

            //float[] input = new float[data];
            

            //for (int i = 0; i < data; i++)
            //{
            //    Console.WriteLine("Enter data number");
            //        input[i] = Convert.ToSingle(Console.ReadLine());
            //}

            //Console.Write("Number you want to search :    ");
            //float number = Convert.ToSingle((Console.ReadLine()));

            //while (Console.ReadLine().ToLower() != "end")
            //{
            //    for (int i = 0; i < data; i++)
            //    {
            //        if (input[i]==number)
            //        {
            //            Console.WriteLine("Your desired number is found:   "+number);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Number is not found");
            //        }
            //    }
            //}

            Console.Write("Cuantos datos reservo: ");
            int repeticiones = Convert.ToInt32(Console.ReadLine());
            float numero;
            float[] listaNumeros = new float[repeticiones];

            for (int i = 1; i < repeticiones; i++)
            {
                Console.Write("Dime numero {0} para guardar en la lista: ", i);
                listaNumeros[i] = Convert.ToSingle(Console.ReadLine());
            }

            Console.Write("Que numero comprueba en la lista? ");
            numero = Convert.ToSingle(Console.ReadLine());

            while (Console.ReadLine() != "end")
            {
                for (int i = 1; i < repeticiones; i++)
                {
                    if (listaNumeros[i] == numero)
                        Console.WriteLine("El número {0} existe en la lista",
                                          numero);

                }
            }
            
        }
    }
}
