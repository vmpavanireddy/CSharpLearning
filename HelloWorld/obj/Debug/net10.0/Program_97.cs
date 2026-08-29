using System;

interface IAttackable
{
    void Attack();
}

abstract class Character : IAttackable
{
    public void Move()
    {
        Console.WriteLine("Character moves");
    }

    public abstract void Attack();
}

class Player : Character
{
    public override void Attack()
    {
        Console.WriteLine("Player attacks");
    }
}

class Program_97
{
    static void Main()
    {
        Character character = new Player();

        character.Move();
        character.Attack();
    }
}