using System;
public class program{
	public static void Main(){
		Console.WriteLine("********BONUS SALARY********");
		Console.WriteLine("enter your work hour:");
		int work=Convert.ToInt32(Console.ReadLine());
		if (work >0 && work <=10){
			Console.WriteLine("you are not working any more in our company!");
		}
		else if (work >=11 && work <=25){
			Console.WriteLine("you will not have bonous salary!");
		}
		else {
			Console.WriteLine("congrats you will have BONUS SALARY!");
		}
		Console.ReadKey();
	}
}