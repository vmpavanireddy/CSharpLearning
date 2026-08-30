using System;

interface IMovable
{
    void Move();
}

interface IAttackable
{
    void Attack();
}

class Player : IMovable, IAttackable
{
    public void Move()
    {
        Console.WriteLine("Player moves");
    }

    public void Attack()
    {
        Console.WriteLine("Player attacks");
    }
}

class Program_1_8
{
    static void Main()
    {
        Player player = new Player();

        player.Move();
        player.Attack();
    }
}