using System;
public class program{
	public static void Main(){

Console.Clear();
        	
        	Console.WriteLine(">>>>> INTERNATIONAL GAMING / COOKING COMPITION <<<<< ");
        
            Console.WriteLine("Tell Me Your Name: ");
            string nam = Console.ReadLine();

            Console.WriteLine("Gender Please ?  ( male / female) ");
            string gen = Console.ReadLine();


            if ( gen  == "male")
            {
            	Console.WriteLine(nam);
            	Console.WriteLine("You Can Play : ( Cricket , Fotball , Hokey , Computer Car Racing , Table Tanes , Snoker )");
            	Console.WriteLine("You Can Also Cook Any Thing You Like");
            }
            else if ( gen == "female" )
            {
            	Console.WriteLine(nam);
            	Console.WriteLine(" You Can Cook Any Thing You Like : ( Chiness , Italian , Pakistani Food , Junk Food , BBQ )");
            	Console.WriteLine("You Can Also Play Games : ( Computer Games , Table Tanes , 100 Meter Race ) ");
            }
            else
            {
            	Console.WriteLine("Sorry Please Give Your Gender Correctly ?");
            }

        	Console.ReadLine();
	}
}