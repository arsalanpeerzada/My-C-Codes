using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_attempt_password
{
    class Program
    {
        static void Main(string[] args)
        {
           

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter User name ");
                string name = Console.ReadLine().ToLower();
                Console.WriteLine("Enter Password");
                string pass = Console.ReadLine().ToLower();


                if (name=="username" || pass=="password")
                {
                    Console.WriteLine("Login Successful");
                    break;
                }
                else
                {
                    if (i==4)
                    {
                        Console.WriteLine("Your request is rejected");
                        Console.ReadLine();
                        break;
                    }
                    Console.WriteLine("Login attempt fail!  retry");
                    Console.ReadLine();
                }
                
            }
            //Console.Clear();
           
        }
    }
}
