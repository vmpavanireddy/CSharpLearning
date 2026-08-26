using System;

class Player
{
    public int Health;
}

class Program_80
{
    static void Main()
    {
        int a = 10;
        int b = a;

        b = 20;

        Console.WriteLine(a);
        Console.WriteLine(b);


        Player p1 = new Player();
        p1.Health = 100;

        Player p2 = p1;

        p2.Health = 50;

        Console.WriteLine(p1.Health);
        Console.WriteLine(p2.Health);
    }
}