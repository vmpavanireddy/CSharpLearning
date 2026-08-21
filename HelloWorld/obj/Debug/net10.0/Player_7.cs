using System;

// 1. Create object
Player_7 player = new Player_7("Alex");

// 2. Call methods
player.TakeDamage(20);

// 3. Read data
Console.WriteLine(player.Health);


class Player_7
{
    // Data
    public string Name { get; private set; }
    public int Health { get; private set; }

    // Constructor
    public Player_7(string name)
    {
        Name = name;
        Health = 100;
    }

    // Behavior
    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            Health -= damage;
        }
    }
}