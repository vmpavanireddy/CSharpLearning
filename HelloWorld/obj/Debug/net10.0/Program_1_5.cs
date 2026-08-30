using System;

class Character
{
    public virtual void Attack()
    {
        Console.WriteLine("Character attacks");
    }
}

class Player : Character
{
    public override void Attack()
    {
        Console.WriteLine("Player attacks");
    }
}

class Warrior : Player
{
    public override void Attack()
    {
        Console.WriteLine("Warrior attacks");
    }
}

class Program_1_5
{
    static void Main()
    {
        Character character = new Warrior();

        character.Attack();
    }
}