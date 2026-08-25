using System;

class Weapon
{
    public void Attack()
    {
        Console.WriteLine("Weapon attacks");
    }
}

class Player_75
{
    Weapon weapon;

    public Player()
    {
        weapon = new Weapon();
    }

    public void Attack()
    {
        weapon.Attack();
    }
}

class Program
{
    static void Main()
    {
        Player player = new Player();

        player.Attack();
    }
}