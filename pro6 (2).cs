using System;
public class year
{
	public static void Main()
	{
		Console.WriteLine("***LEEP YEAR OR NOT***");
		Console.WriteLine("Enter the Year");
		int year=Convert.ToInt32(Console.ReadLine());
		
		if(year%4==0)
		{
			Console.WriteLine("leap Year : "+year);

		}
		else
		{
			Console.WriteLine("Not a Leap Year :"+year);
		}
		Console.ReadKey();
		

			
	}
}
