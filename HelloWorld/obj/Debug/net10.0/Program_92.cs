using System;

abstract class Character
{
    public abstract void Attack();
}

class Player : Character
{
    public override void Attack()
    {
        Console.WriteLine("Player attacks with sword");
    }
}

class Enemy : Character
{
    public override void Attack()
    {
        Console.WriteLine("Enemy attacks with claws");
    }
}

class Program_92
{
    static void Main()
    {
        Player player = new Player();
        Enemy enemy = new Enemy();

        player.Attack();
        enemy.Attack();
    }
}