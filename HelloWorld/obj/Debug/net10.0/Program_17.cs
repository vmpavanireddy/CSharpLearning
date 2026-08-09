//Abstraction in C#
using System;

abstract class Payment
{
    public abstract void MakePayment();
}

class UpiPayment : Payment
{
    public override void MakePayment()
    {
        Console.WriteLine("Payment made using UPI");
    }
}
class CreditCardPayment : Payment
{
    public override void MakePayment()
    {
        Console.WriteLine("Payment made using Credit Card");
    }
}
class Program_17
{
    static void Main()
    {
        UpiPayment payment = new UpiPayment();

        payment.MakePayment();
    }
}