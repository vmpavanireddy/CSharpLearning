using System;

interface IAttackable
{
    void Attack();
}

abstract class Character : IAttackable
{
    public void Attack()
    {
        Console.WriteLine("Character attacks");
    }
}

class Player : Character
{
}

class Program_65
{
    static void Main()
    {
        Player player = new Player();

        player.Attack();
    }
}