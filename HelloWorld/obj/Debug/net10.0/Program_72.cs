using System;

class Enemy
{
    // 1. Create an event
    public event Action OnDeath;

    public void Die()
    {
        Console.WriteLine("Enemy died");

        // 2. Trigger the event
        OnDeath?.Invoke();
    }
}

class Program_72
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

        // 3. Subscribe
        enemy.OnDeath += GiveXP;
        enemy.OnDeath += PlayDeathSound;

        // 4. Enemy dies
        enemy.Die();
    }
}