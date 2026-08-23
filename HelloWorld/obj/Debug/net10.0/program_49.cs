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
class program_49
{
    static void Main(string[] args)
    {
        IAttackable player = new Player();
        player.Attack();
    }
}