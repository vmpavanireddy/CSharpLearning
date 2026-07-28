using System;
public class Login
{
    public void system()
    {
        string name = "admin";
        string pass = "12345";

        Console.Write("Enter Username: ");
        string username = Console.ReadLine();

        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        if (username == name && password == pass)
        {
            Console.WriteLine("Login Successful");
        }
        else
        {
            Console.WriteLine("Invalid Username or Password");
        }
    }
}