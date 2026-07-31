//Combining Access Modifiers
//public string Name { get; private set; }
//get is public.set is private.

using System;

class Employee_id
{
    public string EmployeeId { get; private set; }

    public Employee_id(string id)
    {
        EmployeeId = id;
    }
}

class Employee_ids
{
    static void Main()
    {
        Employee_id employee = new Employee_id("EMP001");

        Console.WriteLine(employee.EmployeeId);

        // employee.EmployeeId = "EMP002"; ❌ Error
    }
}