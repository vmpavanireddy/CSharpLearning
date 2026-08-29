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

class Program_94
{
    static void Main()
    {
        Player p = new Player();
        Character c = p;

        p.Attack();
        c.Attack();
    }
}