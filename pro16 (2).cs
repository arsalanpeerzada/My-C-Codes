using System;
public class program{
	public static void Main(){
		Console.WriteLine("enter your range of money");
		int money=Convert.ToInt32(Console.ReadLine());
		if (money>=0 && money<= 5000){
			Console.WriteLine("you can buy only chaina set");
		}
		else if (money > 5000 && money <= 8000){
			Console.WriteLine("go for tablet leave mobile");
		}
		else {Console.WriteLine("uff visit www.whatmobile.com i am not your servent .. huh !");}
		Console.ReadKey();
	}
}