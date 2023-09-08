//   1
//  22
// 333
//4444
//Input variable is n = row

using System;

public class Program{
	public static void Main(){
		int n = Int32.Parse(Console.ReadLine());
		int i = 1;
		while( i <= n){
			int space = n-i;
			while(space != 0 && space <= n){
				Console.Write(" ");
				space--;
			}
			int j = 0;
			while(j < i){
				Console.Write(i);
				j++;
			}
			Console.WriteLine();
			i++;
		}
	}
}
	