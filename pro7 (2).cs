
using System;
public class bill
{
	public static void Main()
	{
		Console.WriteLine("***PTCL BILL***");
		Console.WriteLine("Enter the Number of Calls");
		int calNum=Convert.ToInt32(Console.ReadLine());
		
		if(calNum<=100)
		{
			Console.WriteLine("FIX CALL RATE : " + 100);
		}
		else if(calNum>100 && calNum<=150)
		{
			double a = calNum-100;
			double b = a*0.6;
			Console.WriteLine(b);
		}
		else if(calNum>150 && calNum<=200)
		{
			double c =calNum-100;
			double d =c*0.5;
			Console.WriteLine(d);
		}
		else if(calNum>200)
		{
			double e =calNum-100;
			double f = e*0.4;
			Console.WriteLine(f);
		}
		Console.ReadKey();

		

	}
}
