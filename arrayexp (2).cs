using System;

class Arrays
{
	static void Main()
	{
		//declaration
		;
		//int[] experimentalArray = new int[];
		//int[] zeroArray = new int[0];

		//initialization
		//string[] studenNames = new string[]{"Fawad", "Haseeb", "Adnan", "Saad", "Qaiser"};

		//code
		Console.WriteLine("Enter Capacity..");
		int capacity = Convert.ToInt32(Console.ReadLine());
		if (capacity>0)
		{
			int[] studentIds = new int[capacity];
			for (int i=0;i<capacity;i++)
			{
				Console.WriteLine("\nEnter " + i + " ID:");
				studentIds[i] = Convert.ToInt32(Console.ReadLine());
			}
			for (int a = 0;a<capacity;a++)
			{
				Console.WriteLine("\nID number " + a + ": " + studentIds[a]);
			}
			int sum = 0;
			for (int c = 0;c<capacity;c++)
			{
				sum = sum + studentIds[c];
			}
			Console.WriteLine("\nAverage of the array is: " + sum/capacity);
			
			
			}
			else
			{
				Console.WriteLine("You entered a negatice integer, please try again with a positive input..");
			}
		
		
	}
}	