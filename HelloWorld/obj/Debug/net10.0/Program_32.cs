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
        
    }
}