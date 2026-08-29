using System;

abstract class Character
{
    public void Move()
    {
        Console.WriteLine("Character moves");
    }

    public abstract void Attack();
}

class Player : Character
{
    public override void Attack()
    {
        Console.WriteLine("Player attacks");
    }
}

class Program_91
{
    static void Main()
    {
        Player player = new Player();

        player.Move();
        player.Attack();
    }
}