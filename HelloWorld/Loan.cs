using System;
public class Loan
{
    public void Eligibility()
    {
        int age = 22;
        int salary = 28000;
        if (age >= 18 && salary >= 25000)
        {
            Console.WriteLine("Loan approved");
        }
        else
        {
            Console.WriteLine("Lona rejected");
        }

    }
}