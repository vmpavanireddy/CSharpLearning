using System;

class Character
{
    public void Attack()
    {
        Console.WriteLine("Character attacks");
    }
}

class Player : Character
{
    public new void Attack()
    {
        Console.WriteLine("Player attacks");
    }
}

class Program_60
{
    static void Main()
    {
        Player player = new Player();

        player.Attack();
    }
}