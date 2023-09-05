//Find if characters of string is small or capital alphabet or number
using System;

public class Program{

    static void Main(){
        string inputchar;
        Console.WriteLine("Please input a character:");
        inputchar = Console.ReadLine();
        
        foreach (char ch in inputchar){
        int ascii = (int)ch;
        if(ascii >= 65 && ascii <= 90)
            Console.WriteLine("The character " + ch + " is capital alphabet");
        else if(ascii >=97 && ascii <= 122)
            Console.WriteLine("The character " + ch + " is small alphabet");
        else if(ascii >= 48 && ascii <= 57)
            Console.WriteLine("The character " + ch + " is number");
        else
            Console.WriteLine("The character " + ch + " is special character"); 
        }
    }
}