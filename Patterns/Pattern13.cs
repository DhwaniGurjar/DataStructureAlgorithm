//A
//BB
//CCC
//Print the above patterns where n = row

using System;

public class Program{
	public static void Main(){
		int n = Int32.Parse(Console.ReadLine());
		int i = 1;
		char ch = 'A';
		while (i <= n)
		{ 
			int j = 1;
			while (j <= i){
				Console.Write(ch);				
				j++;
			}			
			int nextch = (int)ch + 1;
			ch = (char)nextch;
			Console.WriteLine();
			i++;
		}
	}
}