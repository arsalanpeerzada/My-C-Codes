using System;
public class program{
	public static void Main(){
		int numcopies=15;
		
		Console.WriteLine("please enter the number of copies you want to buy:");
		int copy=Convert.ToInt32(Console.ReadLine());
		if (copy > numcopies){
			Console.WriteLine("I Have only"+numcopies+" ..you can buy only"+numcopies);
		}
		else { 
			Console.WriteLine("thankyou for visiting our shop");
		}
		Console.ReadKey();
	}
}