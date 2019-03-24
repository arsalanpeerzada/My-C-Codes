
using System;
public class main
{
	public static void Main()
	{
		Console.WriteLine("****Nationality * Age * Gender****");
		Console.WriteLine("Enter the Nationality");
		string nation =Console.ReadLine();
		Console.WriteLine("Enter the Age");
		int age=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the Gender");
		string gender = Console.ReadLine();

		if(nation=="Pakistani" && age>=1 && age<=5 && gender=="Male")
		{
			Console.WriteLine("Pakistani infant baby boy");
		}
		else if(nation=="Pakistani" && age>18 && gender=="Female" )
		{
			Console.WriteLine("Enter the distance");
			double distance=Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter the time");
			double time=Convert.ToDouble(Console.ReadLine());
			double speed = distance/time;
			Console.WriteLine("Speed : "+speed);
		}
		else if(nation=="China" && age==15 || age==16 && gender=="Male" || gender=="Female")
		{
			Console.WriteLine("Enter the Area");
			int a = Convert.ToInt32(Console.ReadLine());
			int volume=Convert.ToInt32(Math.Pow(a,3));
			Console.WriteLine("Volume : "+volume);

		}
		else if(nation=="Russia" && age>=10 && age<=45  && gender=="Female")
		{	
			for(int i=0;i<=4;i++)
			{
			Console.WriteLine("The Hungry Cyber Pet v 03");
				
			}
		}
		else
		{
			Console.WriteLine("Enter The Number");
			int a =Convert.ToInt32(Console.ReadLine());
			for(int i=0;i<a;i++)
			{
				Console.WriteLine("I am sorry I cant help you.");
			}
		}


		
		
		Console.ReadKey();


	}
}
