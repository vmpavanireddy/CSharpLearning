using System;
public class empl
{
    public string Name { get; set; }

    private double _salary;  // private field

    public double Salary
    {
        get { return _salary; }
        set
        {
            if (value >= 0)
                _salary = value;
            else
                Console.WriteLine("Invalid salary!");
        }
    }
}
public class em
{
    public static void Main(String[] args)
    {
        empl emp = new empl();

        emp.Name = "Pavani";

        emp.Salary = 50000;   // valid
        emp.Salary = -1000;   // invalid

        Console.WriteLine(emp.Name);
        Console.WriteLine(emp.Salary);
    }
}