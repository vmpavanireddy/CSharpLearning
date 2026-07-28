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
        int result = Add(10, 20);
        Console.WriteLine(result);
        StartProgram();
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
    //Returning Values-Send the answer back to the place where the method was called.
    //Every int method must return an int.
    static int Add(int a, int b)
    {
        return a + b;
    }
    //Methods Can Call Other Methods
    static void StartProgram()
    {
        Console.WriteLine("Starting...");

        ShowMenu();
    }

    static void ShowMenu()
    {
        Console.WriteLine("1. Login");
        Console.WriteLine("2. Exit");
    }
}