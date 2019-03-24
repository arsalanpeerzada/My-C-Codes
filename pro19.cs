using System;
public class point{
	public static void Main(){
		Console.WriteLine("enter your off time from one of these:");
		Console.WriteLine("4,5,6,7");
		int offtime=Convert.ToInt32(Console.ReadLine());
		if (offtime==4 || offtime==5)
		{
			Console.WriteLine("you will go in Point 1!");
		}
		else if (offtime==6|| offtime==7)
		{
			Console.WriteLine("you will go in point 2!");
		}
		else{ Console.WriteLine("use public transport!");}
		Console.ReadKey();
	}
}