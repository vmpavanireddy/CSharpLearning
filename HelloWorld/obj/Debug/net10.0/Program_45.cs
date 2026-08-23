using System;
interface IMovable
{
    void Move();
}

interface IPlayer : IMovable
{
    void Attack();
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
}
class Program_45
{
    static void Main(string[] args)
    {
        IPlayer player = new Player();
        player.Move();
        player.Attack();
    }
}