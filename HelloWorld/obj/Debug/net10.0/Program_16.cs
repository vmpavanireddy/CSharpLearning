using System;
//Overloading,Same method name, different parameters.
class Program_16
{
    static void Main(string[] args)
    {
        Console.WriteLine(Add(5, 10)); // Calls the first Add method
        Console.WriteLine(Add(5.5, 10.5)); // Calls the second Add method
        Console.WriteLine(Add(5, 10, 15)); // Calls the third Add method
    }

    // Method to add two integers
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Method to add two doubles
    static double Add(double a, double b)
    {
        return a + b;
    }

    // Method to add three integers
    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}