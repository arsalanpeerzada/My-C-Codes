using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace database
{
    class Program
    {
        struct book
        {
            public string title;
            public string author;
        }

        static void Main(string[] args)
        {
            int capacity = 1000;
            book[] books = new book[capacity];
            bool repeat = true;
            string option;
            string search;
            bool found=true;
            int amount = 0;


            do
            {
                Console.WriteLine();
                Console.WriteLine("\t Books DataBase");
                Console.WriteLine();
                Console.WriteLine("1-Add a new Book");
                Console.WriteLine("2- Display all books");
                Console.WriteLine("3- Exact search for any book");
                Console.WriteLine("4- Partial search");
                Console.WriteLine("5- Delete a book");
                Console.WriteLine("0- Exit");
                Console.Write("Enter an option: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        if (amount < capacity)
                        {
                             Console.WriteLine("Enter data for book {0}",amount+1);
                             Console.Write("Enter the name of the book: ");
                             books[amount+1].title = Console.ReadLine().ToLower();

                             Console.Write("Enter the author name:  ");
                             books[amount+1].author = Console.ReadLine().ToLower();
                             amount++;
                             Console.WriteLine();
                        }
                        else
                            Console.WriteLine("Database is full");
                        break;

                    case "2":
                        if (amount==0)
                        {
                            Console.WriteLine("No data found");
                        }
                        else
                        {
                            for (int i = 1; i < amount; i++)
                            {
                                Console.WriteLine(@"Book name:  "+books[i].title+"   , Author name:  "+books[i].author);

                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("Enter the book to search");
                        search = Console.ReadLine();
                        if (found)
                        {
                            for (int i = 1; i < amount; i++)
                            {
                                if (search == books[i].title)
                                {
                                    Console.WriteLine("Book Found");
                                    Console.WriteLine("Book " + books[i].title + "  is at number: "+i+1);
                                    found = false;
                                }
                            }
                        }

                        if (found)
                            {
                                Console.WriteLine("Book not found");
                            }
                        
                        
                            break;

                            

                    case "4":
                            search = Console.ReadLine();
                        for(int i=1; i < amount; i++)
                        {
                        if(books[i].title.ToLower().Contains(search.ToLower())||books[i].author.ToLower().Contains(search.ToLower())) 
                        Console.WriteLine("{0}= in= {1}= search",books[i].title);
                        }
                        break;
                    case "5":
                        if (amount==0)
                        {
                            Console.WriteLine("No data to delete");
                        }
                        else
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                Console.WriteLine("Enter number of book",amount);
                                int postdelete= Convert.ToInt32(Console.ReadLine());
                                for (postdelete-=1;postdelete < amount-1; postdelete++)
                                {
                                     books[i]=books[i+1];
                                     amount--;
                                }
                            }
                        }
                        break;
                    case "0":
                        Console.WriteLine("End");
                        Console.ReadLine();
                        repeat=false;
                        break;
                    default:
                        Console.WriteLine("You entered wrong option");
                        break;
                }
                
            } while (repeat);
        }
    }
}
