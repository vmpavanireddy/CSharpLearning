using System;

interface IAttackable
{
    void Attack();
}

class Weapon
{
    public void Fire()
    {
        Console.WriteLine("Weapon fires");
    }
}

class Character
{
    public virtual void Move()
    {
        Console.WriteLine("Character moves");
    }
}

class Player : Character, IAttackable
{
    private Weapon weapon;

    public event Action OnDeath;

    public Player()
    {
        weapon = new Weapon();
    }

    public override void Move()
    {
        Console.WriteLine("Player moves");
    }

    public void Attack()
    {
        weapon.Fire();
    }

    public void Die()
    {
        Console.WriteLine("Player died");

        OnDeath?.Invoke();
    }
}

class Program_1_13
{
    static void GameOver()
    {
        Console.WriteLine("Game Over");
    }

    static void Main()
    {
        Player player = new Player();

        player.OnDeath += GameOver;

        player.Move();
        player.Attack();
        player.Die();
    }
}