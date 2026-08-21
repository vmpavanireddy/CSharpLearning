using System;

Player_0 player = new Player_0("Hero", 100);

Console.WriteLine(player.Name);
Console.WriteLine(player.Health);

player.TakeDamage(30);

Console.WriteLine(player.Health);

player.Heal(20);

Console.WriteLine(player.Health);


class Player_0
{
    public string Name { get; private set; }

    public int Health { get; private set; }

    public Player_0(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            Health -= damage;

            if (Health < 0)
            {
                Health = 0;
            }
        }
    }

    public void Heal(int amount)
    {
        if (amount > 0)
        {
            Health += amount;

            if (Health > 100)
            {
                Health = 100;
            }
        }
    }
}