using System;

Player_8 player = new Player_8("Alex", 100);

Console.WriteLine(player.Name);
Console.WriteLine(player.Health);

player.TakeDamage(30);

Console.WriteLine(player.Health);


class Player_8
{
    public string Name { get; private set; }
    public int Health { get; private set; }

    public Player_8(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            Health -= damage;
        }
    }
}