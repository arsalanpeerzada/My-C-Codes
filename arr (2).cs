using System;
public class program{
	public static void Main(){
		Console.WriteLine("enter the number of capacity:" );
		int num=Convert.ToInt32(Console.ReadLine());
		if(num>0){

		int[] number=new int []{10,1,2,3,4,5,6,6,7,8,9,11,15,16};
	
		for (int i=0; i<=num; i++)
		{
			Console.Write(number[i]);
		}
		else Console.WriteLine("please enter positive num:");
		}
	}
}