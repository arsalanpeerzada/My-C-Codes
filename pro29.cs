using System;
public class program{
	public static void Main(){


        	Console.Clear();
        	
        	Console.WriteLine(" Intresting About IICT And Programming Fundamentals ");
        	Console.WriteLine("Which You Like To Know About ? ");
        	Console.WriteLine("IICT ?             Programming Fundamentals ?");

        	string a = Console.ReadLine();
        	if (a == "iict")
        	{
        		Console.WriteLine("               INTRODUCTION TO INFORMATION AND COMMUNICATION TECHNOLOGIES               ");
        		Console.WriteLine("Information and communication technologies are fast and automated, interactive and multimodal, and they support the rapid communication and representation of knowledge to many audiences and its adaptation in different contexts. They transform the ways that students think and learn and give them greater control over how, where and when they learn.");
        	}
        	else
        	{
        		Console.WriteLine("               PROGRAMMING FUNDAMENTAL               ");
        		Console.WriteLine(" Programming is a core activity of computer science. It is a skill for creation. Once you can do it, the sky's the limit over what you can make computers do. A program is just a plan of action a machine can follow. From such plans comes everything the computers you see around you do.  ");
        	}
        	Console.ReadLine();
	}
}