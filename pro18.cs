using System;
public class program{
	public static void Main(){
		Console.WriteLine("**********welcome to letter case**********");
		Console.Write("Enter a character: "); 
		char ch = (char)Console.Read();

if (Char.IsUpper(ch))
 { 
 	Console.WriteLine("The character is an uppercase letter.");
 	 } 
 	 else if (Char.IsLower(ch)) 
 	 { 
 	 	Console.WriteLine("The character is a lowercase letter."); 
 	 	} 
 	 	else if (Char.IsDigit(ch))
 	 	 {
 	 	  Console.WriteLine("The character is a number.");
 	 	   } 
 	 	   else
 	 	    { Console.WriteLine("The character is not alphanumeric."); }
	}
}