using System;

Enemy enemy = new Enemy("Goblin", 50);

Console.WriteLine(enemy.Name);
Console.WriteLine(enemy.Health);

enemy.TakeDamage(20);

Console.WriteLine(enemy.Health);


class Enemy
{
    public string Name { get; private set; }
    public int Health { get; private set; }

    public Enemy(string name, int health)
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

        if (Health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Console.WriteLine(Name + " died!");
    }
}