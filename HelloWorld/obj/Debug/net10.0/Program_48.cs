using System;
interface IAttackable
{
    void Attack();
}

class Player : IAttackable
{
    public void Attack()
    {
        Console.WriteLine("Player attacks");
    }
}

class Enemy : IAttackable
{
    public void Attack()
    {
        Console.WriteLine("Enemy attacks");
    }
}
class Program_48
{
    static void Main(string[] args)
    {
        IAttackable player = new Player();
        IAttackable enemy = new Enemy();

        player.Attack();
        enemy.Attack();
    }
}