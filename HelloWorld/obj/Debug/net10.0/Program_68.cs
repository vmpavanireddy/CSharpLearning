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

class Program_68
{
    static void Main()
    {
        IAttackable attacker = new Player();

        attacker.Attack();
    }
}