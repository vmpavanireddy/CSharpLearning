using System;

abstract class Character
{
    public abstract void Attack();
}

class Player : Character
{
    public override void Attack()
    {
        Console.WriteLine("Player attacks");
    }
}

class Program_56
{
    static void Main()
    {
        Player player = new Player();

        player.Attack();
    }
}