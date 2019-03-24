using System;
public class program{
	public static void Main(){
	Console.WriteLine("****CLASS SHEDULE****");
	Console.WriteLine("enter your class id:");
	int id=Convert.ToInt32(Console.ReadLine());
	if ( id==60305){
		Console.WriteLine("Programing Fundemantel in LAB 3");
	}
	else if (id==60306){
		Console.WriteLine("IICT in LAB 1");
	}
	else if(id==60304){
		Console.WriteLine("VLM in AUDI");
	}
	else if(id==60307){
		Console.WriteLine(" PIS in R-13");
	}
	else{Console.WriteLine("This ID is not your id");}
	Console.ReadKey();
	}
}