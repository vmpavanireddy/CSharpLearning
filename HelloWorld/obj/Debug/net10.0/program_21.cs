using System;
//Interface doesn't normally contain implementation:It's describing what must exist.
interface IPayment
{
    void MakePayment();
    void Refund();
}
class UpiPayment : IPayment
{
    public void MakePayment()
    {
        Console.WriteLine("UPI payment");
    }

    public void Refund()
    {
        Console.WriteLine("UPI refund");
    }
}
class program_21
{
    static void Main(string[] args)
    {
        UpiPayment payment = new UpiPayment();
        payment.MakePayment();
        payment.Refund();

    }
}