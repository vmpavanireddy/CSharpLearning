using System;

class Health
{
    public void TakeDamage()
    {
        Console.WriteLine("Player takes damage");
    }
}

class Weapon
{
    public void Attack()
    {
        Console.WriteLine("Player attacks");
    }
}

class Movement
{
    public void Move()
    {
        Console.WriteLine("Player moves");
    }
}

class Inventory
{
    public void Open()
    {
        Console.WriteLine("Inventory opened");
    }
}

class Player
{
    Health health;
    Weapon weapon;
    Movement movement;
    Inventory inventory;

    public Player()
    {
        health = new Health();
        weapon = new Weapon();
        movement = new Movement();
        inventory = new Inventory();
    }

    public void Play()
    {
        movement.Move();
        weapon.Attack();
        health.TakeDamage();
        inventory.Open();
    }
}

class Program_76
{
    static void Main()
    {
        Player player = new Player();

        player.Play();
    }
}