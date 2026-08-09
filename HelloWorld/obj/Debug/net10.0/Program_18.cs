using System;

abstract class Payment
{
    public double Amount { get; set; }

    public void ShowAmount()
    {
        Console.WriteLine($"Amount: {Amount}");
    }

    public abstract void MakePayment();
}

class UpiPayment : Payment
{
    public override void MakePayment()
    {
        Console.WriteLine("Processing UPI payment...");
    }
}

class Program_18
{
    static void Main()
    {
        Payment payment = new UpiPayment();

        payment.Amount = 1500;

        payment.ShowAmount();
        payment.MakePayment();
    }
}