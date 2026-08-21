using System;

BankAccount_1 account = new BankAccount_1();

Console.WriteLine(account.Balance);

account.Deposit(500);

Console.WriteLine(account.Balance);

class BankAccount_1
{
    public int Balance { get; private set; }

    public BankAccount_1()
    {
        Balance = 0;
    }

    public void Deposit(int amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }
}