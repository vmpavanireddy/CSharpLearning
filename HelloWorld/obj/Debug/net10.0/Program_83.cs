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

class Enemy : Character
{
    public override void Attack()
    {
        Console.WriteLine("Enemy attacks");
    }
}

class Program_83
{
    static void Main()
    {
        Player player = new Player();
        Enemy enemy = new Enemy();

        player.Move();
        player.Attack();

        enemy.Move();
        enemy.Attack();
    }
}