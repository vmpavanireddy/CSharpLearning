using System;
interface IPaymentService
{
    void ProcessPayment(decimal amount);
}
class program_28
{
    static void Main(string[] args)
    {
        IPaymentService paymentService = new CreditCardPaymentService();
        paymentService.ProcessPayment(100.00m);
    }
}