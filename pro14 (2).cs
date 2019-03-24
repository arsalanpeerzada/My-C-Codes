using System;
public class program{
	public static void Main(){
		Console.WriteLine("welcome to fruit shop");
		Console.WriteLine("enter day");
		string day =Convert.ToString(Console.ReadLine());
		if (day == "monday"){
			Console.WriteLine("appllies 40 rps per Kg");
		}
		else if (day == "tuesday"){
			Console.WriteLine("appllies 60 rps per Kg");
		}
		else{
			Console.WriteLine("appllies 50 rps per Kg");
		}
		Console.ReadKey();
	}
}