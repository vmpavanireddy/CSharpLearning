using System;
//Interface properties
interface IEmployee
{
    string Name { get; set; }

    double Salary { get; set; }

    void Work();
    //Interface with multiple members
    void TakeLeave();
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
        IEmployee employee = new Developer();
        employee.Name = "pavani";
        employee.Salary = 60000;

        Console.WriteLine($"Employee Name: {employee.Name}");
        Console.WriteLine($"Employee Salary: {employee.Salary:C}");

        employee.Work();

    }
}