using System;

interface IMovable
{
    void Move();
}

class Player : IMovable
{
    public void Move()
    {
        Console.WriteLine("Player moves");
    }
}

class Program_95
{
    static void Main()
    {
        Player player = new Player();

        player.Move();
    }
}