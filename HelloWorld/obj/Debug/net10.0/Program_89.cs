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

class Program_89
{
    static void GiveXP()
    {
        Console.WriteLine("Player gets XP");
    }

    static void PlaySound()
    {
        Console.WriteLine("Death sound plays");
    }

    static void UpdateUI()
    {
        Console.WriteLine("UI updated");
    }

    static void Main()
    {
        Enemy enemy = new Enemy();

        enemy.OnDeath += GiveXP;
        enemy.OnDeath += PlaySound;
        enemy.OnDeath += UpdateUI;

        enemy.Die();
    }
}