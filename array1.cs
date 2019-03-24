using System;
public class program{
	public static void Main(){
		int[] number= new int[20]{0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19};
		Console.WriteLine("enter any of number");
		int a=Convert.ToInt32(Console.ReadLine());
		
		for (int i=0;i<=19;i++)
		{
			if (number[i] == a)
			{
				Console.WriteLine("NUMBER FOUND");
				
			}
			else if(a > 19)
		{
			Console.WriteLine("NOT FOUND!");
			
		}
		}
	}
}