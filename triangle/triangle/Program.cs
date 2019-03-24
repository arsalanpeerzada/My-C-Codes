using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
         
        Console.Write("Enter your name: ");
        name = Console.ReadLine();
         
        if (name.Length % 2 == 0)
            name += " ";
         
        int position = name.Length / 2;
        int maxRows = name.Length / 2 + 1;
        int amount = 1;
         
         
        for (int i=0; i<maxRows; i++)
            {
            for(int j=0;j<position;j++)
            Console.Write(" ");
            Console.WriteLine(name.Substring(position,amount));
            position --;
            amount +=2;
        }
        }
    }
}
