using System;

abstract class Character
{
    public void Move()
    {
        Console.WriteLine("Character moves");
    }
}

class Player : Character
{
}

class Program_54
{
    static void Main()
    {
        Player player = new Player();

        player.Move();
    }
}