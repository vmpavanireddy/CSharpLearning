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
class CashPayment : Payment
{
    public override void MakePayment()
    {
        Console.WriteLine("Payment made using Cash");
    }
}
class Program_17
{
    static void Main()
    {
        UpiPayment payment = new UpiPayment();

        payment.MakePayment();
        Payment payment1 = new UpiPayment();
        Payment payment2 = new CreditCardPayment();
        Payment payment3 = new CashPayment();

        payment1.MakePayment();
        payment2.MakePayment();
        payment3.MakePayment();
    }
}