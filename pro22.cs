using System;
public class program{
	public static void Main(){

	Console.WriteLine("**Wonders Of The World**");

        	Console.WriteLine(" type : New   OR  Old ");
        	string a = Console.ReadLine();

        	if (a == "new")
        	{
        		Console.WriteLine(" 1-Great Pyramid of Giza      , 2-Hanging Gardens of Babylon           , 3-Statue of Zeus at Olympia ,      4-Temple of Artemis at Ephesus ,      5-Mausoleum at Halicarnassus ,      6-Colossus of Rhodes  ,      7-Lighthouse of Alexandria");
        	}
        	else if (a == "old")
        	{
        		Console.WriteLine(" 1-Chichen Itza,      2-Christ the Redeemer,      3-Great Wall of China,      4-Machu Picchu,      5-Petra,      6-Taj Mahal, and      7-Colosseum.");
        	}
        	else
        	{
        		Console.WriteLine("I'm Just Asking New OR Old");
        	}
        	
        	
        	
        	Console.ReadLine();
	}
}