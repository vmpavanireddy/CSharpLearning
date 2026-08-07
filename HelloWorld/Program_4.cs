using System;
class Employee_2
{
    public string Name { get; set; }

    public string EmployeeId { get; }

    private double salary;

    public double Salary
    {
        get
        {
            return salary;
        }

        private set
        {
            salary = value;
        }
    }

    public Employee_2(string id)
    {
        EmployeeId = id;
    }

    public void IncreaseSalary(double amount)
    {
        if(amount>0)
            Salary += amount;
    }
}
class Program_4
{
    static void Main(string[] args)
    {
        Employee_2 emp = new Employee_2("E123");
        emp.Name = "John Doe";
        emp.IncreaseSalary(5000);
        Console.WriteLine($"Employee Name: {emp.Name}, ID: {emp.EmployeeId}, Salary: {emp.Salary}");
    }
}