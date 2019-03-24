using System;
public class numbers
{
	public static void Main()
	{
		Console.WriteLine("**POSITIVE OR NEGATIVE**");
		Console.WriteLine("Enter the number");
		int num=Convert.ToInt32(Console.ReadLine());
		
		if(num>=0)
		{
			Console.WriteLine("Positive Number");
		}
		else
		{
			Console.WriteLine("Negative number");
		}
		Console.ReadKey();

			
	}
}
