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

class Program_84
{
    static void Main()
    {
        Character character1 = new Player();
        Character character2 = new Enemy();

        character1.Attack();
        character2.Attack();
    }
}