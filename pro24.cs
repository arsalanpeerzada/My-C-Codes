using System;
public class program{
	public static void Main(){

	Console.WriteLine(" First Tell Me What's Your Age: ? Then I'll Decide That You Are Able Or Not To Go Picnic With Us ");
        	int a = Convert.ToInt32(Console.ReadLine());

        	if ( a >= 15)
        	{
        		Console.WriteLine("you can enjoy picnic ");
        	}
        	else
        	{
        		Console.WriteLine("Sorry You Are Under 15 You Will Not Come With Us");
        	}
        	Console.ReadLine();
	}
}