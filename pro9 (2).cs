
using System;
public class program
{
	public static void Main()
	{	Console.WriteLine("...%%**STUDY PLAN**%%...");

		Console.WriteLine(" Choose any Course from the following !" );
		Console.WriteLine("1.Game Theory, 2.Agile Software Development, 3.Software Process Management, 4.Psychology , 5.Advance Programming");
		Console.WriteLine("type Course Name");
		string cName=Console.ReadLine();

		if(cName=="Game Theory" || cName == "game theory")
		{
			Console.WriteLine("Enter the First Number");
			int fisrt=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the second Number");
			int second=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the Third Number");
			int third=Convert.ToInt32(Console.ReadLine());

			if(fisrt>second && fisrt>third)
			{
				Console.WriteLine("The highest number == "+fisrt);
			}
			else if(second>third && second>fisrt)
			{
				Console.WriteLine("The highest number == "+second);
			}
			else if(third>fisrt && third>second)
			{
				Console.WriteLine("The highest number == "+third);
			}
			if(fisrt<second && fisrt<second)
			{
				Console.WriteLine("The lowest number == "+fisrt);
			}
			else if(second<third)
			{
				Console.WriteLine("The lowest number == "+second);
			}
			else
			{
				Console.WriteLine("The lowest number == "+third);
			}
		}
		else if(cName=="Agile Software Development" || cName=="agile software development" || cName=="Software Process Management" || cName=="software process management")
		{
			Console.WriteLine("++ Select one of these options: ++ ");
			Console.WriteLine("++ Requirement Engineering, Designing, Implementation, Testing , Maintenance ++");
			Console.WriteLine("Enter Your One Option");
			string option=Console.ReadLine();
			if(option=="Requirement Engineering" || option=="requirement engineering" || option=="Designing" || option=="designing" || option=="Implementation" || option=="implementation" || option=="Testing" || option=="testing" || option=="Maintenance" || option=="maintenance")
			{
				Console.WriteLine("Valid Input");
			}
			else
			{
				Console.WriteLine("Invalid Input");
			}

		}
		else if(cName=="Psychology" || cName=="psychology")
		{
			Console.WriteLine("Presenting yourself as end-user and criticizing your own work!");
		}
		else if(cName=="Advance Programming" || cName=="advance programming")
		{
			Console.WriteLine("Enter the number from the given option");
			Console.WriteLine("100, 200, 300, 400");
			Console.WriteLine("Enter the number");
			int num=Convert.ToInt32(Console.ReadLine());

			if(num==100)
			{
				Console.WriteLine("Object Oriented Programming");
			}
			else if(num==200)
			{
				Console.WriteLine("Data Structures");
			}
			else if(num==300)
			{
				Console.WriteLine("Design Patterns");
			}
			else if(num==400)
			{
				Console.WriteLine("Design Patterns");

			}
			else
			{
				Console.WriteLine("No other courses are available now!");
			}

		}
		Console.ReadKey();


	}
}
