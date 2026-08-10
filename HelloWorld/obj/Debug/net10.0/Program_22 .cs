//Multiple Interfaces
using System;
interface IPrintable
{
    void Print();
}

interface IScannable
{
    void Scan();
}
class Printer : IPrintable, IScannable
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning...");
    }
}
class Program_22
{
    static void Main(string[] args)
    {
        Printer printer = new Printer();

        printer.Print();
        printer.Scan();
    }
}