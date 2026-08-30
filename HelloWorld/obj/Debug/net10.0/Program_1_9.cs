using System;

interface IMovable
{
    void Move();
}

interface IAttackable
{
    void Attack();
}

interface IPlayer : IMovable, IAttackable
{
    void Heal();
}

class Player : IPlayer
{
    public void Move()
    {
        Console.WriteLine("Move");
    }

    public void Attack()
    {
        Console.WriteLine("Attack");
    }

    public void Heal()
    {
        Console.WriteLine("Heal");
    }
}

class Program_1_9
{
    static void Main()
    {
        Player player = new Player();

        player.Move();
        player.Attack();
        player.Heal();
    }
}