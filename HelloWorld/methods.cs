using System;
public class Methods
{
    static void Main(string[] args)
    {
        //methods
        PrintWelcome();
        //method with parameter
        Greet("pavani");
        //method with multiple parameters
        Student("divya", 19);
    }
    static void PrintWelcome()
    {
        Console.WriteLine("Welcome to C#");
    }
    static void Greet(string name)
    {
        Console.WriteLine($"Hello {name}");
    }
     static void Student(string nam, int age)
    {
        Console.WriteLine($"Name : {nam}");
        Console.WriteLine($"Age : {age}");
    }
    
}