using System;
public class Triangle
{
	public static void Main()
	{
		Console.WriteLine("*****TRIANGLE*****");
		Console.WriteLine("Enter the first number");
		int first =Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the second number");
		int second =Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the third number");
		int third =Convert.ToInt32(Console.ReadLine());
		
		if(first==second && first==third)
		{
			Console.WriteLine("Triangle is valid");
		}
		else
		{
			Console.WriteLine("Triangle is not valid");
		} 
		

		Console.ReadKey();

			
	}
}
