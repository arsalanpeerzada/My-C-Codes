using System;
public class program{
	public static void Main(){
		Console.WriteLine("Enter the length of  arrary ");
		int length=Convert.ToInt32(Console.ReadLine());
		int [] arr=new int[length];
		for(int i=0;i<arr.Length;i++)
		{
			Console.WriteLine("Enter the value of index"+i);
			arr[i]=Convert.ToInt32(Console.ReadLine());
		}
	}
}