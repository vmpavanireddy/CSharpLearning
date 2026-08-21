using System;

BankAccount_2 account = new BankAccount_2("Pavani");

account.Deposit(1000);
account.Withdraw(300);

Console.WriteLine(account.Owner);
Console.WriteLine(account.Balance);


class BankAccount_2
{
    public string Owner { get; private set; }
    public int Balance { get; private set; }

    public BankAccount_2(string owner)
    {
        Owner = owner;
        Balance = 0;
    }

    public void Deposit(int amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public void Withdraw(int amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
        }
    }
}