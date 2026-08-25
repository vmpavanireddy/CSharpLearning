using System;

class Enemy
{
    public event Action OnDeath;

    public void Die()
    {
        Console.WriteLine("Enemy died");

        OnDeath?.Invoke();
    }
}

class Program_74
{
    static void GiveXP()
    {
        Console.WriteLine("Player gets XP");
    }

    static void PlayDeathSound()
    {
        Console.WriteLine("Death sound plays");
    }

    static void Main()
    {
        Enemy enemy = new Enemy();

        enemy.OnDeath += GiveXP;
        enemy.OnDeath += PlayDeathSound;

        enemy.Die();
    }
}