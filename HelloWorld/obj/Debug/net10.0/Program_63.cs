using System;

interface IMovable
{
    void Move();
}

interface IPlayer : IMovable
{
    void Attack();
}

class Player : IPlayer
{
    public void Move()
    {
        Console.WriteLine("Player moves");
    }

    public void Attack()
    {
        Console.WriteLine("Player attacks");
    }
}

class Program_63
{
    static void Main()
    {
        Player player = new Player();

        player.Move();
        player.Attack();
    }
}