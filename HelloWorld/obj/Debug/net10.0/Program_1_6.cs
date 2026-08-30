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

class Program_1_6
{
    static void Main()
    {
        IAttackable attackable = new Player();

        attackable.Attack();
    }
}