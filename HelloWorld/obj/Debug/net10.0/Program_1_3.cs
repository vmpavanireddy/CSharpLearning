using System;

abstract class Character
{
    public void Move()
    {
        Console.WriteLine("Character moves");
    }

    public abstract void Attack();
}

class Warrior : Character
{
    public override void Attack()
    {
        Console.WriteLine("Warrior attacks with sword");
    }
}

class Program_1_3
{
    static void Main()
    {
        Warrior warrior = new Warrior();

        warrior.Move();
        warrior.Attack();
    }
}