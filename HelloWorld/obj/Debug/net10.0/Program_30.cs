using System;
class BankAccount
{
    public string AccountHolder { get; set; }
    private double balance;

    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value >= 0)
                balance = value;
        }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
            Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
            Balance -= amount;
    }
}
class Program_30
{
    static void Main(string[] args)
    {


    }
}