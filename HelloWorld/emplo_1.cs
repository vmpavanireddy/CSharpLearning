using System;

public class emplye
{
    public string AccountNumber { get; }   

    public double Balance { get; private set; }  

    public emplye(string accNumber)
    {
        AccountNumber = accNumber;
        Balance = 0;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
            Balance += amount;
        else
            Console.WriteLine("Invalid deposit amount!");
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
            Balance -= amount;
        else
            Console.WriteLine("Invalid or insufficient funds!");
    }
}

class emplo_1
{
    static void Main()
    {
        emplye acc = new emplye("123ABC");

        acc.Deposit(1000);
        acc.Withdraw(300);
        acc.Withdraw(10000);  // invalid

        Console.WriteLine(acc.AccountNumber);
        Console.WriteLine(acc.Balance);
    }
}