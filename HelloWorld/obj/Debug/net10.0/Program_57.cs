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

class Program_57
{
    static void Main()
    {
        Player player = new Player();

        player.Attack();
    }
}