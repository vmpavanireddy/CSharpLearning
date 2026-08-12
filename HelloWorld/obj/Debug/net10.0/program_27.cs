using System;
//Interface properties
interface IEmployee
{
    string Name { get; set; }

    double Salary { get; set; }

    void Work();
}
class Developer : IEmployee
{
    public string Name { get; set; }

    public double Salary { get; set; }

    public void Work()
    {
        Console.WriteLine("Developer is writing code");
    }
}
class program_27
{
    static void Main(string[] args)
    {

    }
}