//Convert Fahrenheit to Celsius degree
using System;

public class Program{

    static void Main(){
      Console.WriteLine("Enter Fahrenheit degree");
      float f = float.Parse(Console.ReadLine());
      float c = (5 * (f - 32))/9;
      Console.WriteLine(c);
      
    }
}