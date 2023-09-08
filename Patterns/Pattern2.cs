//321
//321
//321
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
				Console.Write(n-j+1);
				j++;
			}
			Console.WriteLine();
			i++;
		}
	}
}