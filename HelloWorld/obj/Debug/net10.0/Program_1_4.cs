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

class Program_1_4
{
    static void Main()
    {
        Warrior warrior = new Warrior();

        warrior.Attack();
    }
}