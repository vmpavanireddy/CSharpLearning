//Interface + Polymorphism
using System;
interface ILogger
{
    void Log(string message);
}
class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}
class program_24
{
    static void Main(string[] args)
    {
        ILogger logger = new ConsoleLogger();
        logger.Log("This is a log message.");
    }
}