using System;
public class Employee
{
    public void bonus()
    {
        int salary = 45000;
        int bonus = 0;
        if (salary > 40000)
        {
            bonus = 5000;
        }
        else
        {
            bonus = 2000;
        }
        int total = salary + bonus;
        Console.WriteLine(salary);
        Console.WriteLine(bonus);
        Console.WriteLine("Total: " + total);
    }
}