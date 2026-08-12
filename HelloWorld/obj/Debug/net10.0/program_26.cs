using System;
interface IPayment
{
    void ProcessPayment(decimal amount);
}

class program_26
{
    static void Main(string[] args)
    {
        IPayment paymentMethod = new CreditCardPayment();
        paymentMethod.ProcessPayment(100.00m);

        paymentMethod = new PayPalPayment();
        paymentMethod.ProcessPayment(200.00m);
    }
}