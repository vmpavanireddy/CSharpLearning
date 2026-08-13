using System;
interface IPaymentService
{
    void ProcessPayment(decimal amount);
    bool Pay(double amount);

}
class UpiPayment : IPaymentService
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing UPI payment of ₹{amount}");
    }
    public bool Pay(double amount)
    {
        Console.WriteLine($"Paid ₹{amount} using UPI");

        return true;
    }
}
class program_28
{
    static void Main(string[] args)
    {
        IPaymentService paymentService = new CreditCardPaymentService();
        paymentService.ProcessPayment(100.00m);
        bool paymentResult = paymentService.Pay(100.00);
    }
}