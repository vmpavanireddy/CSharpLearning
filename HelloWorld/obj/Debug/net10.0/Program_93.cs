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

class Program_93
{
    static void Main()
    {
        Character c1 = new Player();
        Character c2 = new Enemy();

        c1.Attack();
        c2.Attack();
    }
}