using System;
public class program{
	public static void Main(){


        	Console.WriteLine(" Select A Colour Then I'll Tell Some Thing Intresting About You ? :) :P");

        	
        	Console.WriteLine(" Blue ");
        	
        	Console.WriteLine(" Red ");
        	
        	Console.WriteLine(" Yellow ");
        	
        	Console.WriteLine(" Green ");
        
        	Console.WriteLine(" Black ");
        
        	Console.WriteLine(" White ");
        
        	Console.WriteLine("Enter Your Colour in Small Latters");

        	string a = Console.ReadLine();

        	if (a == "blue")
        	{
        		
        		Console.WriteLine(" You Must Be Bold Person");
        		
        	}
        	else if (a == "red")
        	{
        
        		Console.WriteLine("Dil Ki Baat Dil Mein Rakhte Ho, Kisi Ko Batana Pasand Nahi Karte ");
        		
        	}
        	else if (a == "yellow")
        	{
        		
        		Console.WriteLine("Kisi Se Bohut Pyaar Karte Ho ");
        
        	}
        	else if (a == "green")
        	{
        
        		Console.WriteLine("Bohut Romantic ho Khud Par Yaqeen Rakhte Ho ");
        
        	}
        	else if (a == "black")
        	{
        
        		Console.WriteLine("Apni Khushi Se Ziada Dosro Ki Khushi Ka Khayal Rakhte Ho ");
        
        	}
        	else if (a == "white")
        	{
        
        		Console.WriteLine("Bohut Flirt Ho ");
        		
        	}
        	else
        	{
        
        		Console.WriteLine("Please Type Coloue Correctly");
        
        	}


        	Console.ReadLine();
	}
}