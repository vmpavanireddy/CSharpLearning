using System;

interface ICharacter
{
    void Attack();
    void Run();
}

abstract class Character : ICharacter
{
    public void Attack()
    {
        Console.WriteLine("Character attacks");
    }

    public abstract void Run();
}

class Player : Character
{
    public override void Run()
    {
        Console.WriteLine("Player runs");
    }
}

class Program_66
{
    static void Main()
    {
        Player player = new Player();

        player.Attack();
        player.Run();
    }
}