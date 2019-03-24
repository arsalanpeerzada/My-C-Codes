using System;
public class program{
	public static void Main(){

	Console.WriteLine("Want To Know Which Company Network You Are Unig ?");

        	Console.WriteLine("Enter Your Three(3) Number Code Of Your Mobile Number");

        	int a = Convert.ToInt32(Console.ReadLine());

        	if (a == 031)
        	{
        		Console.WriteLine("You Are Using Zong Recently");
        	}
        	else if (a == 030)
        	{
        		Console.WriteLine("You Are Using Jazz Recently");
        	}
        	else if (a == 032)
        	{
        		Console.WriteLine("You Are Using Warid Recently");
        	}
        	else if (a == 033)
        	{
        		Console.WriteLine("You Are Using Ufone Recently");
        	}
        	else if (a == 034)
        	{
        		Console.WriteLine("You Are Using Telenor Recently");
        	}
        	else
        	{
        		Console.WriteLine("You Type Wrong Code Please Correct Your Code");
        	}
        	Console.ReadLine();

	}
}