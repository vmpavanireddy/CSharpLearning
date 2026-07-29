using System;
class Employees
{
    public string Name;
    public double Salary;

    public Employees(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    public void Display()
    {
        Console.WriteLine($"{Name} - {Salary}");
    }
}
class employ
{
    static void Main(string[] args)
    {
        Employees emp_id = new Employees("divya", 12000);

        emp_id.Display();
    }
}