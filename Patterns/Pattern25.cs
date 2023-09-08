//1234554321
//1234**4321
//123****321
//12******21
//1********1
//Input variable is n = row

using System;

public class Program{
	public static void Main(){
		int n = Int32.Parse(Console.ReadLine());
		int i = 1;
		while( i <= n){
			int j = 1;
			while( j <= n - i + 1){
				Console.Write(j);
				j++;				
			}		
			int k = 2;
			while(k < 2*(i)){
				Console.Write("*");
				k++;
			}
			int l = n-i+1;
			while( l >= 1){
				Console.Write(l);
				l--;
			}				
			Console.WriteLine();
			i++;
		}
	}
}
	