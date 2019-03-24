using System;
public class digit
{
	public static void Main()
	{
		Console.WriteLine("Enter the digit of 4 numbers");
		short a =Convert.ToInt16(Console.ReadLine());
		
		if(a%2==0 && a%3==0 && a%4==0 && a%12==0)
		{
			Console.WriteLine("THE NUMBER IS DIVISIBLE");
		}
		else
		{
			Console.WriteLine("THE NUMBER IS Not DIVISIBLE");
		}



		Console.ReadKey();

			
	}
}
