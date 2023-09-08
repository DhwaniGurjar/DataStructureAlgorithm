//123
//456
//789
//Print the above patterns where n = row

using System;

public class Program{
	public static void Main(){
		int n = Int32.Parse(Console.ReadLine());
		int i = 1;
		int counter = 1;
		while (i <= n)
		{ 
			int j = 1;
			while (j <= n){
				Console.Write(counter);
				counter++;
				j++;
			}
			Console.WriteLine();
			i++;
		}
	}
}