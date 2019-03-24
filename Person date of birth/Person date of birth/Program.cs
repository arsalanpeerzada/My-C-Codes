using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person_date_of_birth
{
    class Program
    {
        struct Person
        {
            public string Name;
            public dateBirth Date;
            public Mobile phoneNumber;
        }

        struct Mobile
        {
            public int code;
            public int number;
        }

        struct dateBirth
        {
            public int Day;
            public string Month;
            public int Year;

        }

        static void Main(string[] args)
        {



            Console.Write("How many Person's List you want to create:   ");
            int total = Convert.ToInt32(Console.ReadLine());
            Person[] p = new Person[total];
            int d = 0, m = 0, y = 0, phone = 0, code = 0, option = 0, i = 0;
            bool repeat = false;

            do
            {
                Console.WriteLine("Press 1 for Add Name,D.O.B & PhoneNumber");
                Console.WriteLine("Press 2 for Show Name,D.O.B & PhoneNumber");
                Console.WriteLine("Press 3 for Edit Name");

                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write("Enter Name:  ");
                        string Name = Console.ReadLine();
                        Console.WriteLine();
                        p[i].Name = Name;

                        Console.Write("Enter Day:   ");
                        d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (d <= 31 && d > 0)
                        {
                            p[i].Date.Day = d;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Date");
                        }


                        Console.Write("Enter Month:  ");
                        m = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (m <= 12 && m > 0)
                        {
                            if (m == 1)
                            {
                                m = Convert.ToInt32("Jan");
                            }
                            else if (m == 2)
                            {
                                m = Convert.ToInt32("Feb");
                            }
                            else if (m == 3)
                            {
                                m = Convert.ToInt32("Mar");
                            }
                            else if (m == 4)
                            {
                                m = Convert.ToInt32("Apr");
                            }
                            else if (m == 5)
                            {
                                m = Convert.ToInt32("May");
                            }
                            else if (m == 6)
                            {
                                m = Convert.ToInt32("June");
                            }
                            else if (m == 7)
                            {
                                m = Convert.ToInt32("July");
                            }
                            else if (m == 8)
                            {
                                string mon = m.ToString();
                                mon = "Aug";
                                p[i].Date.Month = mon;
                            }
                            else if (m == 9)
                            {
                                m = Convert.ToInt32("Sep");
                            }
                            else if (m == 10)
                            {
                                m = Convert.ToInt32("Oct");
                            }
                            else if (m == 11)
                            {
                                m = Convert.ToInt32("Nov");
                            }
                            else if (m == 12)
                            {
                                m = Convert.ToInt32("Dec");
                            }


                        }
                        else
                        {
                            Console.WriteLine("Invalid Month");
                        }

                        Console.Write("Enter Year:   ");
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        p[i].Date.Year = y;

                        Console.Write("Enter 4 digit service provider Code:   ");
                        code = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        p[i].phoneNumber.code = code;

                        Console.Write("Enter 7 digit number:   ");
                        phone = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        p[i].phoneNumber.number = phone;

                        i++;
                        break;

                    case 2:
                        for (int j = 0; j < total; j++)
                        {
                            Console.WriteLine("Name: {0}, DateOfBirth: {1}/{2}/{3}", p[j].Name, p[j].Date.Day, p[j].Date.Month, p[j].Date.Year);
                            Console.WriteLine("Phone Number:  +92" + code + "-" + phone);
                        }
                        break;

                }
            } while (!repeat);

        }


    }
}

