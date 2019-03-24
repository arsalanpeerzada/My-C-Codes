using System;
public class program{
	public static void Main(){

        	Console.WriteLine("What Whould You Like To Have ?");
        	Console.WriteLine("Juice ?          Soft Drink ?          Shake ?          Tea / Coffe ?");
        	string a = Console.ReadLine();

        	if (a == "juice")
        	{
        		Console.WriteLine("Which Flavor Sir/Madam ?");
        		string b = Console.ReadLine();
        		Console.WriteLine(b + "  juice For U Sir / Madam Enjoy You Drink");
        		Console.WriteLine("70 Rupies Please");
        	}
        	else if (a == "soft drink")
        	{
        		Console.WriteLine("Which Flavor Sir/Madam ?");
        		Console.WriteLine("Pepsi ?          Coca Cola ?          7up ?          Marinda ?        Due ?");
        		string c = Console.ReadLine();
        		Console.WriteLine(c + "   For U Sir / Madam Enjoy You Drink");
        		Console.WriteLine("50 Rupies Please");
        	}
        	else if (a == "shake")
        	{
        		Console.WriteLine("Which Flavor Sir/Madam ?");
        		Console.WriteLine("Banana ?          Mango ?          Strawberry ?          Pineapple ?        Apple ?");
        		string d = Console.ReadLine();
        		Console.WriteLine(d + "   Shake For U Sir / Madam  Enjoy You Drink");
        		Console.WriteLine("120 Rupies Please");
        	}
        	else if (a== "Tea / Coffe")
        	{
        		Console.WriteLine("Which Flavor Sir/Madam ?");
        		Console.WriteLine("Tea ?          Coffe ?          Cold Coffe ?          Black Tea?          Green Tea ?");
        		string e = Console.ReadLine();
        		Console.WriteLine(e + "   For U Sir / Madam  Enjoy You Drink");
        		Console.WriteLine("100 Rupies Please");
        	}
        	else
        	{
        		Console.WriteLine("Sorry Sir / Madam We Don't Have That Thing Which You Want");
        	}


        	Console.ReadLine();

	}
}