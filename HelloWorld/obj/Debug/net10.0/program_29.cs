//Interface vs Inheritance
using System;
interface INotification
{
    void Send(string message);
}
class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending email notification: {message}");
    }
}
class SMSNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending SMS notification: {message}");
    }
}
class WhatsAppNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending WhatsApp notification: {message}");
    }
}
class program_29
{
    static void Main(string[] args)
    {
        INotification notification = new EmailNotification();
        notification.Send("Hello, this is a test email notification.");
        INotification notification2 = new SMSNotification();
        notification2.Send("Hello, this is a test SMS notification.");
        INotification notification3 = new WhatsAppNotification();
        notification3.Send("Hello, this is a test WhatsApp notification.");
    }
}