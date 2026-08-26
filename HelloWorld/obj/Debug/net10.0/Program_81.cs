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

class Program_81
{
    static void Main()
    {
        Player player = new Player();

        player.Move();
        player.Attack();
    }
}