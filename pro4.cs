using System;
public class main
{
	public static void Main()
	{
		Console.WriteLine("Write cost price:");
		int cPrice=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Write the price of selling");
		int sPrice=Convert.ToInt32(Console.ReadLine());
	
		
		if(sPrice>cPrice)
		{
			Console.WriteLine("you will have profit");
		}
		else if(sPrice==cPrice)
		{
			Console.WriteLine("NO PROFIT! NO LOSS!");
		}
		else
		{
			Console.WriteLine("you will have LOSS");
		}



		Console.ReadKey();

			
	}
}
