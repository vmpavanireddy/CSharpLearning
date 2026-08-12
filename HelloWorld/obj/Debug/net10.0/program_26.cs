using System;
interface IPayment
{
    void ProcessPayment(decimal amount);
}
interface IUserService
{
    void CreateUser(string username);
}
interface IProductRepository
{
    void AddProduct(string productName);
}
interface IAuthenticationService
{
    bool Authenticate(string username, string password);
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