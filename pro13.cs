using System;
public class carspeed{
	public static void Main(){
		Console.WriteLine("**********welcome to car speed meter**********");
		Console.WriteLine("enter your car speed");
		double speed=Convert.ToDouble(Console.ReadLine());
		if (speed >0 && speed <=30){
			Console.WriteLine("you are slow");
		}
		else if (speed >30 && speed <=60){
			Console.WriteLine("your are at normal speed");
		}
		else if (speed >60 && speed <=80){
			Console.WriteLine("high speed");
		}
		else {
			Console.WriteLine("you are about to dead..R.I.P");
		}
		Console.ReadKey();
	}
}