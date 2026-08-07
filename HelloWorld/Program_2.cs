using System;
class Player_1
{
    private int health = 100;

    public int Health
    {
        get
        {
            return health;
        }
    }

    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            health -= damage;

            if (health < 0)
                health = 0;
        }
    }

    public void Heal(int amount)
    {
        if (amount > 0)
        {
            health += amount;

            if (health > 100)
                health = 100;
        }
    }
}
class Program_2
{
    static void Main(string[] args)
    {
        Player_1 player = new Player_1();

        Console.WriteLine(player.Health);

        player.TakeDamage(30);

        Console.WriteLine(player.Health);

        player.Heal(20);

        Console.WriteLine(player.Health);
    }
}