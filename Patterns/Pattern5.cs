//1
//22
//333
//4444
//Print the above patterns where n = row

using System;

public class Program{
	public static void Main(){
		int n = Int32.Parse(Console.ReadLine());
		int i = 1;
		while (i <= n)
		{ 
			int j = 1;
			while (j <= i){
				Console.Write(i);
				j++;
			}
			Console.WriteLine();
			i++;
		}
	}
}