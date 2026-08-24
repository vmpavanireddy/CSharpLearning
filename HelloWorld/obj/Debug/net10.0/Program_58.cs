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

class Program_58
{
    static void Main()
    {
        Character character = new Player();

        character.Attack();
    }
}