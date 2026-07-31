
using System;
//examples
class Secret_1
{
    private string password;

    public string Password
    {
        set { password = value; }
    }

    public void Show()
    {
        Console.WriteLine("Password stored!");
    }
}