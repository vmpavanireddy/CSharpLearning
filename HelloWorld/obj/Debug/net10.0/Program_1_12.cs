using System;

class Sword
{
    public void Use()
    {
        Console.WriteLine("Sword attack");
    }
}

class Gun
{
    public void Use()
    {
        Console.WriteLine("Gun attack");
    }
}

class Player
{
    private Sword sword;

    public Player()
    {
        sword = new Sword();
    }

    public void Attack()
    {
        sword.Use();
    }
}

class Program_1_12
{
    static void Main()
    {
        Player player = new Player();

        player.Attack();
    }
}