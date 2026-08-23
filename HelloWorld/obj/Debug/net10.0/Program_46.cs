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
class Enemy : IMovable, IAttackable
{
    public void Move()
    {
        Console.WriteLine("Enemy moves");
    }

    public void Attack()
    {
        Console.WriteLine("Enemy attacks");
    }
}
class Program_46
{
    static void Main(string[] args)
    {
        IMovable playerMovable = new Player();
        IAttackable playerAttackable = new Player();    
        IMovable enemyMovable = new Enemy();
        IAttackable enemyAttackable = new Enemy();  
        enemyMovable.Move();
        enemyAttackable.Attack();
        playerMovable.Move();
        playerAttackable.Attack();
    }
}