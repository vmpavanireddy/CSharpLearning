//Multiple Interfaces
/*IUserService
IEmailService
ILogger
IPaymentService
*/
interface IUserService
{
    void CreateUser(string username, string email);
    void DeleteUser(int userId);
}
interface IEmailService
{
    void SendEmail(string to, string subject, string body);
}
interface ILogger
{
    void Log(string message);
}
interface IPaymentService
{
    void ProcessPayment(decimal amount);
}
class UserService : IUserService, ILogger, IEmailService, IPaymentService
{
    public void CreateUser(string username, string email)
    {
        // Implementation for creating a user
        Log($"User created: {username}, {email}");
    }

    public void DeleteUser(int userId)
    {
        // Implementation for deleting a user
        Log($"User deleted: {userId}");
    }

    public void Log(string message)
    {
        // Implementation for logging
        Console.WriteLine($"Log: {message}");
    }
    public void SendEmail(string to, string subject, string body)
    {
        // Implementation for sending an email
        Console.WriteLine($"Email sent to: {to}, Subject: {subject}");
    }
    public void ProcessPayment(decimal amount)
    {
        // Implementation for processing payment
        Console.WriteLine($"Payment processed: {amount}");
    }
}
class Program_23
{
    static void Main(string[] args)
    {
        UserService userService = new UserService();
        userService.CreateUser("pavani", "pavani@example.com");
        userService.SendEmail("pavani@example.com", "Welcome!", "yo, welcome to my gameplay!");
        userService.ProcessPayment(100.00m);
    }
}