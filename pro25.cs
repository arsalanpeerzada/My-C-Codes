using System;
public class program{
	public static void Main(){
		
        	Console.WriteLine("Enter Your Percentage % ");
            double a = Convert.ToDouble(Console.ReadLine());
            
            	if (a >= 55)
            	{
            		Console.WriteLine("Welcome To Pre-Engineering Best Of Luck For Your Future :) ");
            	}
            	else if (a >= 50)
            	{
            		Console.WriteLine("Welcome To Computer Science Best Of Luck For Your Future :) ");
            	}
            	else if (a >=45)
            	{
            		Console.WriteLine("Welcome To BBA Best Of Luck For Your Future :) ");
            	}
            	else
            	{
            		Console.WriteLine("Sorry We Don't Have Critaria For This Percentage");
            	}
            Console.ReadLine();

	}
}