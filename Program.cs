using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Tanzeela's age ?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Fazla's age ?");
            int age2 = Convert.ToInt32(Console.ReadLine());

            int SUM = age + age2;
            int AVG = SUM / 2;

            Console.WriteLine("The Average of thsese ages is..:" + AVG);
            Console.ReadKey();
        }
    }
}
