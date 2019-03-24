using System;
public class program{
	public static void Main (){
		int i;
		int sum=0;
		int cap;
		Console.WriteLine("enter capacity:");

		if(cap>0){
			int[] num=new int [cap[i]];
			for(i=0;i<cap;i++){
				Console.WriteLine("enter value");
				num[i]=Convert.ToInt32(Console.ReadLine());
				sum=sum+num[i];
			}
			Console.WriteLine("average is"+(sum/cap));
			Console.ReadLine();
		}

	}
}