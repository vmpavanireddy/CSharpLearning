using System;

interface IAttackable
{
    void Attack();
}

class Player : IAttackable
{
    public void Attack()
    {
        Console.WriteLine("Player uses sword");
    }
}

class Enemy : IAttackable
{
    public void Attack()
    {
        Console.WriteLine("Enemy uses claws");
    }
}

class Program_1_7
{
    static void Main()
    {
        IAttackable a = new Player();
        IAttackable b = new Enemy();

        a.Attack();
        b.Attack();
    }
}