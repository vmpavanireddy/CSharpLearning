using System;

interface IMovable
{
    void Move();
}

interface IAttackable
{
    void Attack();
}

interface IHealable
{
    void Heal();
}

class Player : IMovable, IAttackable, IHealable
{
    public void Move()
    {
        Console.WriteLine("Player moves");
    }

    public void Attack()
    {
        Console.WriteLine("Player attacks");
    }

    public void Heal()
    {
        Console.WriteLine("Player heals");
    }
}

class Program_86
{
    static void Main()
    {
        Player player = new Player();

        player.Move();
        player.Attack();
        player.Heal();
    }
}