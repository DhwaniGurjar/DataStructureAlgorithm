//A
//BC
//CDE
//DEFG
//Print the above patterns where n = row

using System;

public class Program{
	public static void Main(){
		int n = Int32.Parse(Console.ReadLine());
		int i = 1;
		char ch = 'A';
		char newch = 'A';
		while (i <= n)
		{ 
			int j = 1;
			int nextch = (int)ch + i - 1;
			newch = (char)nextch;
			while (j <= i){				
				Console.Write(newch);	
				newch++;
				j++;
			}	
			Console.WriteLine();
			i++;
		}
	}
}