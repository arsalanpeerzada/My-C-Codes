
using System;
public class main
{
	public static void Main()
	{
		Console.WriteLine("Enter the first subject number");
		double one=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the second subject number");
		double two=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the third subject number");
		double three=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the fourth subject number");
		double four=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the fifth subject number");
		double five=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the sixth subject number");
		double six=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the seventh subject number");
		double seven=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the eighth subject number");
		double eight=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the ndoubleh subject number");
		double nine=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the tenth subject number");
		double ten=Convert.ToDouble(Console.ReadLine());

		double totalMarks=one+two+three+four+five+six+seven+eight+nine+ten;
		double p1 = totalMarks*100;
		double p2 = p1/1000;
		double p3 =Convert.ToDouble(Math.Round(p2, 2));
		Console.WriteLine("Percentage : "+p3);

		if(p3>=85 && p3<=100)
		{
			Console.WriteLine("Your Grade is = A");
		}
		else if(p3>=70 && p3<85)
		{
			Console.WriteLine("Your Grade is = B");
		}
		else if(p3>=60 && p3<70)
		{
			Console.WriteLine("Your Grade is = C");
		}
		else if(p3>=50 && p3<60)
		{
			Console.WriteLine("Your Grade is = D");
		}
		else if(p3<50 || p3>100)
		{
			Console.WriteLine("You are Fail");
		}
		Console.ReadKey();

	}
}
