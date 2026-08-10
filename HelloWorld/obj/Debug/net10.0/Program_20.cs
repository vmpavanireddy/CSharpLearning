//Interfaces in C#
using System;
//An interface defines a contract — it tells a class what it must be able to do, without deciding how it does it.
//syntax of interface
/*
interface interface_name
{
    //methods
    //properties
    //events
    //indexers
}
*/
interface IPayment
//I is a convention used to indicate an interface.naming convention:I + Name
{
    void MakePayment();
}
//class implements an interface using :
class UpiPayment : IPayment
//UpiPayment agrees to follow the IPayment contract.
{
    public void MakePayment()
    {
        Console.WriteLine("Payment made using UPI");
    }
}
//et's create multiple payment methods.
/*Each one must implement:
MakePayment()
But each can implement it differently.
*/
class CreditCardPayment : IPayment
{
    public void MakePayment()
    {
        Console.WriteLine("Credit Card payment");
    }
}

class CashPayment : IPayment
{
    public void MakePayment()
    {
        Console.WriteLine("Cash payment");
    }
}
class Program_20
{
    static void Main(string[] args)
    {
        UpiPayment payment = new UpiPayment();

        payment.MakePayment();
    }
}