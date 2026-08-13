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
//interface rules
//1. An interface can contain only method signatures, properties, events, and indexers. It cannot contain any implementation code.
//2. An interface cannot have access modifiers (like public, private, etc.) for its members. All members are implicitly public.
//3. An interface cannot have fields or constructors.
//4. A class can implement multiple interfaces, allowing for multiple inheritance of behavior.
//5. An interface can inherit from other interfaces, allowing for the creation of more specialized interfaces.
//6. An interface cannot be instantiated directly; it must be implemented by a class or struct.
//7. A class that implements an interface must provide an implementation for all the members defined in the interface, unless the class is declared as abstract.
//8. An interface can be used as a type, allowing for polymorphism and the ability to work with different implementations of the same interface.
//9. An interface can be used to define contracts for classes, ensuring that they adhere to a specific set of behaviors and methods.
//10. An interface can be used to achieve loose coupling between components, making it easier to change implementations without affecting the rest of the codebase.