using System;
class Employee
{
    public string Name { get; set; }

    public void Work()
    {
        Console.WriteLine("Employee is working");
    }
}

class Developer : Employee
{
    public void WriteCode()
    {
        Console.WriteLine("Developer is writing code");
    }
}

class Tester : Employee
{
    public void RunTests()
    {
        Console.WriteLine("Tester is running tests");
    }
}
class Program_10
{
    static void Main(string[] args)
    {
        Developer dev = new Developer();
        dev.Name = "pavani";
        dev.Work();
        dev.WriteCode();

        Tester tester = new Tester();
        tester.Name = "divya";
        tester.Work();
        tester.RunTests();
    }
}