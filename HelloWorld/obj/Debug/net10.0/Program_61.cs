using System;

class Character
{
    public void Move()
    {
        Console.WriteLine("Character moves");
    }
}

class Player : Character
{
    public void Attack()
    {
        Console.WriteLine("Player attacks");
    }
}

class Warrior : Player
{
    public void UseSword()
    {
        Console.WriteLine("Warrior uses sword");
    }
}

class Program_61
{
    static void Main()
    {
        Warrior warrior = new Warrior();

        warrior.Move();
        warrior.Attack();
        warrior.UseSword();
    }
}