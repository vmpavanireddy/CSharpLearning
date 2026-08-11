//Interface + Dependency Injection
using System;
interface IEmailService
{
    void SendEmail(string message);
}
class EmailService : IEmailService
{
    public void SendEmail(string message)
    {
        Console.WriteLine($"Sending: {message}");
    }
}
class OrderService
{
    private readonly IEmailService emailService;

    public OrderService(IEmailService emailService)
    {
        this.emailService = emailService;
    }

    public void PlaceOrder()
    {
        Console.WriteLine("Order placed");

        emailService.SendEmail("Order confirmation");
    }
}
class Program_25
{
    static void Main(string[] args)
    {
        IEmailService emailService = new EmailService();
        OrderService orderService = new OrderService(emailService);
        orderService.PlaceOrder();
    }
}