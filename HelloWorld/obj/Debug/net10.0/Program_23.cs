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

class Program_23
{
    static void Main(string[] args)
    {

    }
}