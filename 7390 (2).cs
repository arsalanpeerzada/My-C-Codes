using System;
public class ArrayProgram{
	public static void Main(){
		Console.WriteLine("Search FOR EVEN NUMBER");
		Console.WriteLine("Enter the Number");
		int userInput= Convert.ToInt32(Console.ReadLine());
		int[] numbers= new int [15];
		numbers [0]=2;
		numbers [1]=4;
		numbers [2]=6;
		numbers [3]=8;
		numbers [4]=10;
		numbers [5]=12;
		numbers [6]=14;
		numbers [7]=16;
		numbers [8]=18;
		numbers [9]=20;
		numbers [10]=22;
		numbers [11]=24;
		numbers [12]=26;
		numbers [13]=28;
		numbers [14]=30;
		
        if (userInput%2!=0  || userInput>30 ){
        	Console.WriteLine("Number Not Found");
        }
		for(int i=0; i<=14; i++)
		{
			if(numbers[i]==userInput)
			{
				Console.WriteLine("Number Found"+" "+ userInput +" "+ "in index"+ " " + i);
			}
		}
	}
}