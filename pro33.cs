using System;
public class program{
	public static void Main(){
Console.WriteLine(" Enter Your Age ? ");
        	int a = Convert.ToInt32(Console.ReadLine());

        	if ( a > 18)
        	{
        		Console.WriteLine("Now You Are Above 18 Go And Make Your CNIC");
        	}
        	else
          	{
        		Console.WriteLine("Still You Are Under 18 You  Don't Need CNIC");
        	}

        	Console.ReadLine();

	}
}