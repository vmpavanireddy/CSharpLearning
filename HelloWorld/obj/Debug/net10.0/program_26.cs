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
class CreditCardPayment : IPayment, IUserService, IProductRepository, IAuthenticationService
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount:C}");
    }

    public void CreateUser(string username)
    {
        Console.WriteLine($"Creating user: {username}");
    }

    public void AddProduct(string productName)
    {
        Console.WriteLine($"Adding product: {productName}");
    }

    public bool Authenticate(string username, string password)
    {
        Console.WriteLine($"Authenticating user: {username}");
        return true; // Simplified for demonstration
    }
}
class program_26
{
    static void Main(string[] args)
    {

    }
}