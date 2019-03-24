using System;
public class program{
	public static void Main(){
		
		Console.WriteLine("To Know Some Thing Intresting About Yourself : Enter Number Between 10-20 ?");
        	int a = Convert.ToInt32(Console.ReadLine());

        	if (a >=10 && a<=20)
        	{
        		if(a<=12)
        		{
        			Console.WriteLine("You Are So0o Sweet ^_^ ");
        		}
        		if (a>12 && a<=14)
        		{
        			Console.WriteLine("You Are RUDE Personality");
        		}
        		if (a>14 && a<=16)
        		{
        			Console.WriteLine(" You Are So0o So Boring!");
        		}
        		if (a>16 && a<=18)
        		{
        			Console.WriteLine(" You Love SomeOne ;) <3");
        		}
        		if (a>18 && a<=20)
        		{
        			Console.WriteLine("You Have To Many Enimies :O ");
        		}

        	}
        	else
        	{
        		Console.WriteLine("You Enter Wront Number");
        	}


        	Console.ReadLine();

	}
}