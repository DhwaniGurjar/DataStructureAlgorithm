//   *
//  **
// ***
//****
//Input variable is n = row

using System;

public class Program{
	public static void Main(){
		int n = Int32.Parse(Console.ReadLine());
		int i = 1;
		while( i <= n){
			int space = n - i;
			while(space < n && space > 0){
				Console.Write(" ");
				space--;
		}
		int j = 1;
		while (j <= i)
		{
			Console.Write("*");
			j++;
		}
			Console.WriteLine();
			i++;
		}
	}
}
	