using System;

interface IAttackable
{
    void Attack();
}

interface IMovable
{
    void Move();
}

abstract class Character : IAttackable, IMovable
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

class Program_88
{
    static void Main()
    {
        Character character = new Player();

        character.Move();
        character.Attack();
    }
}