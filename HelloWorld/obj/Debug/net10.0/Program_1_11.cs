using System;

class Player
{
    public event Action OnDeath;

    public void Die()
    {
        Console.WriteLine("Player died");

        OnDeath?.Invoke();
    }
}

class Program_1_11
{
    static void GameOver()
    {
        Console.WriteLine("Game Over");
    }

    static void PlaySound()
    {
        Console.WriteLine("Death sound");
    }

    static void Main()
    {
        Player player = new Player();

        player.OnDeath += GameOver;
        player.OnDeath += PlaySound;

        player.Die();

        Console.WriteLine("Removing sound");

        player.OnDeath -= PlaySound;

        player.Die();
    }
}