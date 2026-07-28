using System;
public class Payroll
{
    public void System_pay()
    {
        string emp_name="pavani";
        int salary=100000;
        int bonus =9000;
        int tax=193;
        //Gross Salary
        int gross=salary+bonus;
        int tax_amt=(gross*tax)/100;
        int netsalary=gross-tax_amt;
        Console.WriteLine($"Gross Salary{gross}");
        Console.WriteLine($"Tax Amount{tax_amt}");
        Console.WriteLine($"Net Salary{netsalary}");

    }
}