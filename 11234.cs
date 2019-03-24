using System;
public class program
{
	public static void Main()
	{
	// Console.WriteLine("Enter raw capacity");
	 //int row=Convert.ToInt32(Console.ReadLine());
	 //Console.WriteLine("Enter Column capacity");
	 //int cal=Convert.ToInt32(Console.ReadLine());
	 
	 int [,] array=new int [,]{
                                   {10, 10, 10, 10},
                                   {20, 20, 20, 20},
                                   {30, 30, 30, 30}
	                          };
	 int [,] arr=new int [array.GetLength(1),array.GetLength(0)];


	 for (int i=0;i<array.GetLength(0);i++)
	 {
	 	for(int j=0;j<array.GetLength(1);j++)
	 	{
	 		arr[j,i] = array[i,j];
	 	}
	 }

	 for (int i=0;i<array.GetLength(0);i++)
	 {
	 	for(int j=0;j<array.GetLength(1);j++)
	 	{
	 		Console.Write(array[i,j] + "\t");
	 	}
	 	Console.WriteLine("");
	 }

	 for (int i=0;i<arr.GetLength(0);i++)
	 {
	 	for(int j=0;j<arr.GetLength(1);j++)
	 	{
	 		Console.Write(arr[i,j]+"\t");
	 	}
	 	Console.WriteLine("");
	 }

	}
}
