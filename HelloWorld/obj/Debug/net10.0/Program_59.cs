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
}

class Program_59
{
    static void Main()
    {
        Character character = new Player();

        character.Move();
    }
}