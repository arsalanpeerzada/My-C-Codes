using System;
public class main
{
	public static void Main()
	{
		Console.WriteLine("***LARGEST NUMBER***");
		Console.WriteLine("Enter the first number");
		int first=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the second number");
		int second=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the third number");
		int third=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the fourth number");
		int fourth=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the fifth number");
		int fifth=Convert.ToInt32(Console.ReadLine());
		
		Console.Write("The greatest number.. :");
		if(first>second && first>third && first>fourth && first>fifth)
		{		
			Console.WriteLine(first);	
		}
		else if(second>third && second>fourth && second>fifth)
		{
			Console.WriteLine(second);
		}
		else if(third>fourth && third>fifth)
		{
			Console.WriteLine(third);
		}
		else if(fourth>fifth)
		{
			Console.WriteLine(fourth);
		}
		else
		{
			Console.Write(fifth);
		}
		

		Console.ReadKey();

			
	}
}
