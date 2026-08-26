using System;

class HealthComponent
{
    public int Health = 100;

    public void TakeDamage(int damage)
    {
        Health -= damage;

        Console.WriteLine("Health: " + Health);
    }
}

class MovementComponent
{
    public void Move()
    {
        Console.WriteLine("Player moves");
    }
}

class WeaponComponent
{
    public void Attack()
    {
        Console.WriteLine("Player attacks");
    }
}

class Player
{
    private HealthComponent health;
    private MovementComponent movement;
    private WeaponComponent weapon;

    public Player()
    {
        health = new HealthComponent();
        movement = new MovementComponent();
        weapon = new WeaponComponent();
    }

    public void Move()
    {
        movement.Move();
    }

    public void Attack()
    {
        weapon.Attack();
    }

    public void TakeDamage(int damage)
    {
        health.TakeDamage(damage);
    }
}

class Program_90
{
    static void Main()
    {
        Player player = new Player();

        player.Move();
        player.Attack();
        player.TakeDamage(30);
    }
}