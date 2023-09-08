//   1
//  121
// 12321
//1234321
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
			int j = 1;
			while(i>=j){
				Console.Write(j);
				j++;
			}
			int k = 1;
			while(i > k){
				Console.Write(k);
				k++;
			}
			
			Console.WriteLine();
			i++;
		}
	}
}
	