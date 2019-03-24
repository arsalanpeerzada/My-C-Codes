using System;
public class program{
	public static void Main(){
		int nol;
		char c;
		Console.WriteLine("number of lines:");
		nol = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("enter character");
		c = Convert.ToChar(Console.ReadLine());
		
		PrintS(nol, c);
		PrintS(nol, c);
		PrintS(nol, c);
		PrintS(nol, c);

	}

	public static void PrintS (int _nol, char _c){
		for(int i=0;i<=_nol; i++){
			for(int j=0;j<=i; j++)
			{
				Console.Write(_c);

			}
			Console.WriteLine("");
		}
	}
}