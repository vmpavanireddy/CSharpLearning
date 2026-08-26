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

class Program_85
{
    static void Main()
    {
        Player player = new Player();
        Character character = player;

        player.Attack();
        character.Attack();
    }
}