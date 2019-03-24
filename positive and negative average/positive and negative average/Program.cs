using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace positive_and_negative_average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many number you want to input");
            int input = Convert.ToInt32(Console.ReadLine());
            float positive = 0;
            float negative = 0;

            float []data =new float [input];

            for (int i = 0; i < input; i++)
            {
                Console.Write("Input number :");
                data[i] = Convert.ToSingle(Console.ReadLine());
            }

            for (int i = 0; i < input; i++)
            {
                if (data[i]>0)
                {
                    positive += data[i];
                }
                else if(data[i]<0)
                {
                    negative += data[i];
                }
            }

            Console.Write("Positve Average:  "+ positive / input);
            Console.WriteLine();
            Console.Write("Negative Average:  " + negative / input);
        }
    }
}
