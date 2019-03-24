using System;
public class program{
	public static void Main(){

	Console.WriteLine("Enter Number From 1-100");
        	int a = Convert.ToInt32(Console.ReadLine());

        	if ( a <= 100 )
        	{
        		Console.WriteLine( a * 10);
        	}
        	else
        	{
        		Console.WriteLine("Sorry You Enter Wrong Number Or Greater Than 100");
        	}
        	Console.ReadLine();

	}
}