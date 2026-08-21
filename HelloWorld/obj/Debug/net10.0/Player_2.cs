using System;

Player_2 player = new Player_2();

player.TakeDamage(30);
Console.WriteLine(player.Health);

player.TakeDamage(-20);
Console.WriteLine(player.Health);

class Player_2
{
    public int Health { get; private set; }

    public Player_2()
    {
        Health = 100;
    }

    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            Health -= damage;
        }
    }
}