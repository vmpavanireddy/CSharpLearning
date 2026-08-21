using System;

Player_3 player = new Player_3();

player.TakeDamage(40);
Console.WriteLine(player.Health);

player.Heal(20);
Console.WriteLine(player.Health);

class Player_3
{
    public int Health { get; private set; }

    public Player_3()
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

    public void Heal(int amount)
    {
        if (amount > 0)
        {
            Health += amount;
        }
    }
}