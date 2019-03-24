using System;
public class program{
	public static void Main(){
		Console.WriteLine("enter the day:");
		string day=Console.ReadLine();
		 if (day=="monday"){
			Console.WriteLine("at 8:00 you have to attend yoga classes");
		}
			else if(day=="tuesday"){
				Console.WriteLine("today at 6:00 you have appointment");
			}
			else if (day=="wednesday"){
				Console.WriteLine("meeting in your office");
			}
			else if (day=="thursday"){
				Console.WriteLine("today is your driving classes at 2:00 pm");
			}
			else if (day=="friday"){
				Console.WriteLine("go for namaz at 2:00 pm");
			}
			else if (day=="saturday"){
				Console.WriteLine("sports classes at 11:00 pm");
			}
			else {Console.WriteLine("HOLIDAY!");}
			Console.ReadKey();
	}
}