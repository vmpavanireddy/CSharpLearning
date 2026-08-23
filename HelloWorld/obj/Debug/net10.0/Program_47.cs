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
class Program_47
{
    static void Main(string[] args)
    {
        Player player = new Player();
        player.Move();
        player.Attack();
    }
}