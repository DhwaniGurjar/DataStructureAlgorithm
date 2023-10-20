/* Print fibonacci series i.e., 0,1,1,2,3,5,8,13,21,...*/

using System;					
public class Program
{
	public static void Main()
	{
		int n = 10;
		int a= 0, b = 1;
		Console.WriteLine(a);
		Console.WriteLine(b);
		for( int i = 1; i <= n; i++)
		{
			int sum = a + b;
			Console.WriteLine(sum);
			a = b;
			b = sum;
		}		
	}
}