using System;
public class program{
	public static void Main(){
		Console.WriteLine("**WELCOME TO YOUR NAME MEANING**");
		Console.WriteLine("your name ?");
		string name=Console.ReadLine();
		if(name=="tanzeela")
		{
			Console.WriteLine("you are lovely, preety, out standing! ");
		}
		else if(name=="zeeshan")
		{
			Console.WriteLine("you are not lovely you are loving");
		}
		else if(name=="haleema")
		{
			Console.WriteLine("jhanzoooo ! ");
		}
		else {Console.WriteLine("NOT FOUND!");}
		Console.ReadKey();
	}
}