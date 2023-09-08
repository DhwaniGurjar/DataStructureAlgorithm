//xxxx
//xxx
//xx
//x
//Input variable is n = row

using System;

public class Program{
	public static void Main(){
		int n = Int32.Parse(Console.ReadLine());
		int i = 1;
		while( i <= n){
			int j = n;
			while(i <= j && j <= n){
				Console.Write("x");
				j--;
			}
			Console.WriteLine();
			i++;
		}
	}
}
	