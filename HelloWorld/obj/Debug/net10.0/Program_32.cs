using System;
class User
{
    public string Username { get; set; }
    public string Password { get; set; }

    public bool Login(string user, string pass)
    {
        return user == Username && pass == Password;
    }
}
class Program_32
{
    static void Main(string[] args)
    {
        User user = new User();
        user.Username = "admin";
        user.Password = "password123";

        Console.WriteLine("Enter username:");
        string inputUsername = Console.ReadLine();

        Console.WriteLine("Enter password:");
        string inputPassword = Console.ReadLine();

        if (user.Login(inputUsername, inputPassword))
        {
            Console.WriteLine("Login successful!");
        }
        else
        {
            Console.WriteLine("Invalid username or password.");
        }
    }
}