//1
//21
//321
//4321
//Print the above patterns where n = row

using System;

public class Program{
	public static void Main(){
		int n = Int32.Parse(Console.ReadLine());
		int i = 1;
		while (i <= n)
		{ 
			int row = i;
			int j = 1;
			while (j <= i){
				Console.Write(row);
				row--;
				j++;
			}
			Console.WriteLine();
			i++;
		}
	}
}