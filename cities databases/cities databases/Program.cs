using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cities_databases
{
    class Program
    {
        struct city
        {
            public string name;
            public int inhabitants;
        }
        static void Main(string[] args)
        {
            int maxcities = 500;
            city[] cities = new city[maxcities];
            int amount = 0;
            int currentCityNumber;
            int option;
            string textToSearch;
            bool found;
            string textToModify;
            bool finished = false;

            do
            {
                Console.WriteLine();
                Console.WriteLine("            Cities database    ");
                Console.WriteLine();
                Console.WriteLine("1. Add a new city");
                Console.WriteLine("2. View all cities");
                Console.WriteLine("3. Modify a record");
                Console.WriteLine("4. Insert a new record");
                Console.WriteLine("5. Delete a record");
                Console.WriteLine("6. Search in the records");
                Console.WriteLine("7. Correct the capitalization of the names");
                Console.WriteLine("0. Exit");
                Console.WriteLine();
                Console.Write("Choose an option: ");
                option =Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        finished = true;
                        break;
                    case 1:
                        if (amount > maxcities - 1)
                            Console.WriteLine("the database is full");
                        else
                        {
                            Console.WriteLine("Entering data for city number {0}", amount + 1);
                            Console.Write("Enter the city name: ");
                            cities[amount].name = Console.ReadLine();
                            Console.Write("Enter the inhabitants numbers: ");
                            cities[amount].inhabitants = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("The data was entered correctly");
                            amount++;
                        }
                        break;

                    case 2:
                        for (int i = 0; i < amount; i++)
                        {
                            Console.WriteLine("{0}: {1},{2}", i+1 , cities[amount].name,cities[amount].inhabitants);
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter the city number");
                            currentCityNumber = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter a new data for city number : {0}",currentCityNumber);
                            Console.Write("City name was : {0}   hit Enter to leave as is",cities[currentCityNumber -1].name);
                            textToModify = Console.ReadLine();
                            if (textToModify !=" ")
                            {
                                cities[currentCityNumber - 1].name = Console.ReadLine();
                            }
                            Console.WriteLine("Inhabitants was : {} hit Enter to leave as is", cities[currentCityNumber -1].inhabitants);
                            textToModify = Console.ReadLine();
                            if (textToModify != " ")
                            {
                                cities[currentCityNumber - 1].inhabitants = Convert.ToInt32(Console.ReadLine());
                            }

                        }
                        break;

                    case 4:
                        {
                            if (amount > maxcities-1)
                            {
                                Console.WriteLine("The database if full");
                            }
                            else
                            {
                                Console.WriteLine("Enter the number of the city to modify");
                                currentCityNumber = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Insert a data at {0} position",currentCityNumber);
                                amount++;
                                for (int i = (int)amount; i > currentCityNumber - 1; i--)
                                    cities[i] = cities[i - 1];
                                Console.Write("City Name: ");
                                cities[currentCityNumber - 1].name = Console.ReadLine();
                                Console.Write("Inhabitant :");
                                cities[currentCityNumber - 1].inhabitants = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        break;
                    case 5:
                         Console.Write("Enter the city number for delete: ");
                    currentCityNumber = Convert.ToInt32(Console.ReadLine());
 
                    Console.WriteLine("Deleting the number {0}", currentCityNumber);
 
                    for (int i = currentCityNumber - 1; i < amount; i++)
                    {
                        cities[i] = cities[i + 1];
                    }
                    amount--;
                        break;

                    case 6:
                        Console.Write("Enter the text to search: ");
                    textToSearch = Console.ReadLine();
                    found = false;
                    for (int i = 0; i < amount; i++)
                    {
                        if (cities[i].name.ToUpper().
                                IndexOf(textToSearch.ToUpper()) >= 0)
                        {
                            Console.WriteLine("{0} found in {1}",
                                textToSearch, cities[i].name);
                            found = true;
                        }
                    }
                    if (!found)
                        Console.WriteLine("Not found.");
                    break;
                       
                    case 7:
                        for(int i=0;i<amount;i++) 
                        {
                            string correctedName = Console.ReadLine();
                            //first the whole nametolowercase 
                            string lowerCaseName=cities[i].name.ToLower();
                            //then first letter uppercase correctedname 
                            lowerCaseName.Substring(0,1).ToUpper(); 
                            lowerCaseName.Substring(1); 
                            //and then letter s after a space 
                            for (int j = 1; j <= correctedName.Length; j++)
                                if (correctedName == lowerCaseName)
                                    correctedName.Substring(1, 2);
                                    cities[i].name = correctedName;
                        }
                            
                            break;
                   default:
                            Console.WriteLine("wrongoption");
                            break;
                            
                }
            } while (!finished);
	
        }
    }
}
