//1234
//1234
//1234
//1234
//Print the above patterns

using System;

public class Program{
	public static void Main(){
		int n = Int32.Parse(Console.ReadLine());
		int i = 1;
		while (i <= n)
		{ 
			int j = 1;
			while (j <= n){
				Console.Write(j);
				j++;
			}
			Console.WriteLine();
			i++;
		}
	}
}