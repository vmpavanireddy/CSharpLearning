using System;

class Character
{
    public virtual void Attack()
    {
        Console.WriteLine("Character attacks");
    }
}

class Player : Character
{
    public override void Attack()
    {
        Console.WriteLine("Player uses sword!");
    }
}

class Enemy : Character
{
    public override void Attack()
    {
        Console.WriteLine("Enemy attacks with claws!");
    }
}

class Program_14
{
    static void Main()
    {
        Character player = new Player();
        Character enemy = new Enemy();

        player.Attack();
        enemy.Attack();
    }
}