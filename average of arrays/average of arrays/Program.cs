using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace average_of_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            Console.WriteLine("Enter start to Progress");
            int[] data = new int [1000];
            string start = Console.ReadLine().ToLower();
            int sum = 0;
            

            while (start!="end")
            {
                Console.Write("Enter a number:      ");
                data[i] = Convert.ToInt32(Console.ReadLine());
                sum += data[i];
                Console.Write("Sum:   "+sum);
                Console.WriteLine();
            }

            for (int h = 0; h < data.Length; h++)
            {
                Console.Write("Numbers are:   "+data[h]);
                Console.WriteLine("Final Sum"+sum);
            }
        }
    }
}
