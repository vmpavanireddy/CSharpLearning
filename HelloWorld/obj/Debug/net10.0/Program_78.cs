using System;

interface IMovable
{
    void Move();
}

class MovementComponent : IMovable
{
    public void Move()
    {
        Console.WriteLine("Player moves");
    }
}

class Player
{
    private IMovable movement;

    public Player()
    {
        movement = new MovementComponent();
    }

    public void Move()
    {
        movement.Move();
    }
}

class Program_78
{
    static void Main()
    {
        Player player = new Player();

        player.Move();
    }
}