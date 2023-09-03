
using System; 
//using keyword is used take reference from .NET framework namespaces
//System is a default class which has methods such as Console.WriteLine()

class FirstProgram //class Name
{
    static void Main(){ //Main method is Entry point of console application 
        Console.WriteLine("This is the basic C# Program"); //a static method used to display text in console
    }
   // Main is declared inside a class or struct. Main must be static and it need not be public.
   //(In this example, it receives the default access of private.) 
   //The enclosing class or struct is not required to be static.
   //Main can either have a void, int, Task, or Task<int> return type.
   //The Main method can be declared with or without a string[] parameter that contains command-line arguments

   //The following list shows valid Main signatures:
    public static void Main() { }
    public static int Main() { }
    public static void Main(string[] args) { }
    public static int Main(string[] args) { }
    public static async Task Main() { }
    public static async Task<int> Main() { }
    public static async Task Main(string[] args) { }
    public static async Task<int> Main(string[] args) { }
}