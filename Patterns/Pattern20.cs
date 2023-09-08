//1111
// 222
//  33
//   4
//Input variable is n = row

using System;

public class Program{
	public static void Main(){
		int n = Int32.Parse(Console.ReadLine());
		int i = 1;
		while( i <= n){
			int space = i-1;
			while(space != 0){
				Console.Write(" ");
				space--;
			}
			int j = n;
			while( j <= n && i <= j){
				Console.Write(i);
				j--;
			}
			Console.WriteLine();
			i++;
		}
	}
}
	