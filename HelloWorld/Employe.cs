//Two Properties, One Validated
using System;

class Emplo
{
    public string Name { get; set; }

    private double salary;

    public double Salary
    {
        get
        {
            return salary;
        }

        set
        {
            if (value >= 0)
            {
                salary = value;
            }
        }
    }
}

class Employe
{
    static void Main()
    {
        Emplo employee = new Emplo();

        employee.Name = "John";
        employee.Salary = 5000;

        Console.WriteLine(employee.Name);
        Console.WriteLine(employee.Salary);

        employee.Salary = -500;

        Console.WriteLine(employee.Salary);
    }
}