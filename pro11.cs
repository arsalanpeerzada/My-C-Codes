using System;
public class main{
	public static void Main(){
		Console.WriteLine("*****VOVEL*****");
		Console.WriteLine("enter Alphabet:");
		char vovel=Convert.ToChar(Console.ReadLine());
		if(vovel=='a' ||vovel== 'e' || vovel== 'i' || vovel== 'o' || vovel== 'u'){
			Console.WriteLine("this is vovel!");
		}
		else {
			Console.WriteLine("not vovel!");
		}
		Console.ReadKey();
	}
}