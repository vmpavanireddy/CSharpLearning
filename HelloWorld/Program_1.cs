//Encapsulation is the process of hiding data and controlling how it is accessed.
using System;
class BankAccount_1
{
    //public double Balance;
    private double balance;

    public double Balance
    {
        get
        {
            return balance;
        }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
        }
    }
}
class Program_1
{
    static void Main(string[] args)
    {
        /*BankAccount_1 account = new BankAccount_1();

        account.Balance = 1000;

        account.Balance = -50000;
    
        Console.WriteLine(account.Balance);
        //Anyone can change the balance.
        */
        //There is no public setter.
        BankAccount_1 account = new BankAccount_1();

        account.Deposit(1000);

        Console.WriteLine(account.Balance);

        account.Withdraw(200);

        Console.WriteLine(account.Balance);
    }
}